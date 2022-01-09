using Server.Core.Provider;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Server.Utils.Constrant;
using static Server.Utils.Helpers;

namespace Server.DAO
{
    public class ReaderDAO : DAO<ReaderDTO>
    {
        public static ReaderDAO instance = new ReaderDAO();
        public override string table => "DocGia";

        public override bool delete(string key)
        {
            return Database.excute((SqlConnection con, SqlTransaction trans) =>
            {
                SqlCommand cm = new SqlCommand("DeleteReader", con);
                cm.Transaction = trans;
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@MADG", key);

                cm.ExecuteNonQuery();
            });
        }

        public override List<ReaderDTO> getAll()
        {
            List<ReaderDTO> rs = new List<ReaderDTO>();

            Database.excuteQuery((SqlConnection con) =>
            {
                SqlCommand cm = new SqlCommand("GetReaders", con);
                cm.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cm.ExecuteReader();

                rs = ReaderDTO.readDatabaseData(reader);
            });

            return rs;
        }

        public List<ReaderDTO> getAdultReader()
        {
            List<ReaderDTO> rs = new List<ReaderDTO>();

            Database.excuteQuery((SqlConnection con) =>
            {
                SqlCommand cm = new SqlCommand("GetAdultReaders", con);
                cm.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cm.ExecuteReader();

                rs = ReaderDTO.readDatabaseData(reader);
            });

            return rs;
        }

        public override bool insert(ReaderDTO data)
        {
            return Database.excute((SqlConnection con, SqlTransaction trans) =>
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = con;
                cm.Transaction = trans;
                cm.CommandType = CommandType.StoredProcedure;
                data.CreatedDate = DateTime.Now.ToString();
                if (data.Type.Equals("Adult"))
                {
                    data.MADG = generateReaderCode(ReaderType.Adult);
                    cm.CommandText = "CreateAdultReader";
                    cm.Parameters.AddWithValue("@MADG", data.MADG);
                    setParamsAdult(cm, (AdultDTO) data);
                }
                else
                {
                    data.MADG = generateReaderCode(ReaderType.Child);
                    cm.CommandText = "CreateChildReader";
                    cm.Parameters.AddWithValue("@MADG", data.MADG);
                    setParamsChild(cm, (ChildDTO) data);
                }

                cm.ExecuteNonQuery();
            });
        }

        public override bool update(ReaderDTO data)
        {
            return Database.excute((SqlConnection con, SqlTransaction trans) =>
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = con;
                cm.Transaction = trans;
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@MADG", data.MADG);
                if (data.Type.Equals("Adult"))
                {
                    cm.CommandText = "UpdateAdultReader";
                    setParamsAdult(cm, (AdultDTO)data);
                }
                else
                {
                    cm.CommandText = "UpdateChildReader";
                    setParamsChild(cm, (ChildDTO)data);
                }

                cm.ExecuteNonQuery();
            });
        }

        public string generateReaderCode(ReaderType type) 
        {
            if(type.Equals(ReaderType.Adult))
            {
                return generateAdultCode(AdultPrefix);
            }

            return generateChildCode(ChildPrefix);
        }

        private string generateAdultCode(string prefixCode)
        {
            string code = "";

            Database.excuteQuery((SqlConnection con) =>
            {
                SqlCommand cm = new SqlCommand("GetLastestAdultReaderCode", con);
                cm.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int newestCode = int.Parse(reader["code"].ToString()) + 1;
                    string seq = newestCode.ToString();
                    string suffix = new String('0', 6 - seq.Length);
                    code = $"{prefixCode}{suffix}{seq}";
                }
                else
                {
                    code = $"{prefixCode}000001";
                }
            });

            return code;
        }

        private string generateChildCode(string prefixCode)
        {
            string code = "";

            Database.excuteQuery((SqlConnection con) =>
            {
                SqlCommand cm = new SqlCommand("GetLastestChildReaderCode", con);
                cm.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int newestCode = int.Parse(reader["code"].ToString()) + 1;
                    string seq = newestCode.ToString();
                    string suffix = new String('0', 6 - seq.Length);
                    code = $"{prefixCode}{suffix}{seq}";
                }
                else
                {
                    code = $"{prefixCode}000001";
                }
            });

            return code;
        }

        public bool checkUserExist(string userName)
        {   
            List<ReaderDTO> rs = new List<ReaderDTO>();

            Database.excuteQuery((SqlConnection con) =>
            {
                SqlCommand cm = new SqlCommand("CheckUserExist", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@UserName", userName);

                SqlDataReader reader = cm.ExecuteReader();

                rs = ReaderDTO.readDatabaseData(reader);
            });

            return rs.Any();
        }

        protected void setParamsAdult(SqlCommand cm, AdultDTO data)
        {
            foreach (var item in AdultDTO.getMapping())
            {
                cm.Parameters.AddWithValue($"@{item.Value}", data.GetType().GetProperty(item.Key).GetValue(data) ?? "");
            }
        }

        protected void setParamsChild(SqlCommand cm, ChildDTO data)
        {
            foreach (var item in ChildDTO.getMapping())
            {
                if(item.Key.Equals("Protector"))
                {
                    if(String.IsNullOrEmpty(data.Protector))
                    {

                        cm.Parameters.AddWithValue($"@{item.Value}", DBNull.Value);
                    }
                    else
                    {
                        cm.Parameters.AddWithValue($"@{item.Value}", data.Protector);
                    }
                    continue;
                }
                cm.Parameters.AddWithValue($"@{item.Value}", data.GetType().GetProperty(item.Key).GetValue(data) ?? "");
            }
        }
    }
}
