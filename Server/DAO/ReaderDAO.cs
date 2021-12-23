using Server.Core.Provider;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DAO
{
    public class ReaderDAO : DAO<ReaderDTO>
    {
        public static ReaderDAO instance = new ReaderDAO();
        public override string table => "readers";

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

        public override bool insert(ReaderDTO data)
        {
            return Database.excute((SqlConnection con, SqlTransaction trans) =>
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = con;
                cm.Transaction = trans;
                cm.CommandType = CommandType.StoredProcedure;
                if(data.Type.Equals("Adult"))
                {
                    cm.CommandText = "CreateAdultReader";
                    setParamsAdult(cm, (AdultDTO) data);
                }
                else
                {
                    cm.CommandText = "CreateChildReader";
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

        protected void setParamsAdult(SqlCommand cm, AdultDTO data)
        {
            foreach (var item in AdultDTO.getMapping())
            {
                cm.Parameters.AddWithValue(item.Value, data.GetType().GetProperty(item.Key).GetValue(data));
            }
        }

        protected void setParamsChild(SqlCommand cm, ChildDTO data)
        {
            foreach (var item in ChildDTO.getMapping())
            {
                cm.Parameters.AddWithValue(item.Value, data.GetType().GetProperty(item.Key).GetValue(data));
            }
        }
    }
}
