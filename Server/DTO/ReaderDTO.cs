using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Core.Provider;

namespace Server.DTO
{
    public class ReaderDTO 
	{
		public string MADG { get; set; }
		public string DisplayName { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Birth { get; set; }
		public string Email { get; set; }
		public string Sex { get; set; }
		public string Avatar { get; set; }
		public string PhoneNumber { get; set; }
		public string Nation { get; set; }
		public string Nationality { get; set; }
		public string Type { get; set; }
		public string CreatedDate { get; set; }

		public string getReaderType
		{
			get;
		}

		protected static Dictionary<String, String> mappingParams = new Dictionary<String, String>()
		{
			{"DisplayName", "DisplayName"},
			{"Password", "Password"},
			{"Birth", "Birth"},
			{"Email", "Email"},
			{"Sex", "Sex"},
			{"Avatar", "Avatar"},
			{"PhoneNumber", "PhoneNumber"},
			{"Type", "Type"},
			{"CreatedDate", "CreatedDate"}
		};

		protected static Dictionary<String, String> mappingTableField = new Dictionary<String, String>()
		{
			{"MADG", "MaDocGia" },
			{"DisplayName", "TenDocGia"},
			{"Password", "MatKhau"},
			{"Birth", "NgaySinh"},
			{"Email", "Email"},
			{"Sex", "GioiTinh"},
			{"Avatar", "AnhDaiDien"},
			{"PhoneNumber", "SDTDocGia"},
			{"Nation", "DanToc"},
			{"Nationality", "QuocTich"},
			{"Type", "Loai"},
			{"CreatedDate", "NgayTao"}
		};

		public static Dictionary<string, string> getMapping()
        {
			return mappingParams;
        }

		public static void setMapping(string key, string value)
		{
			mappingParams.Add(key, value);
		}

		public static List<ReaderDTO> readDatabaseData(SqlDataReader r)
        {
			List<ReaderDTO> readerList = new List<ReaderDTO>();

			while(r.Read())
            {
				ReaderDTO reader = new ReaderDTO();
				foreach (var item in mappingTableField)
				{
					string value = r[item.Value] == null ? "" : r[item.Value].ToString();
					reader.GetType().GetProperty(item.Key).SetValue(reader, value, null);
				}
				readerList.Add(reader);
			}

			return readerList;
        }
	}
}
