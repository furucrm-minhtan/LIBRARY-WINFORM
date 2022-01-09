using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Core.Provider;
using static Server.Utils.Constrant;

namespace Server.DTO
{
	public class AdultDTO : ReaderDTO 
	{
		public string Id { get; set; }
		public string IssuedPlace { get; set; }
		public string Job { get; set; }
		public string Degree { get; set; }
        public new string getReaderType => ReaderType.Adult.ToString();

        protected static new Dictionary<String, String> mappingParams = new Dictionary<String, String>()
		{
			{"DisplayName", "DisplayName"},
			{"Password", "Password"},
			{"Birth", "Birth"},
			{"Email", "Email"},
			{"Sex", "Sex"},
			{"Avatar", "Avatar"},
			{"PhoneNumber", "PhoneNumber"},
			{"Nation", "Nation"},
			{"Nationality", "Nationality"},
			{"Id", "Id"},
			{"IssuedPlace", "IssuedPlace"},
			{"Job", "Job"},
			{"Degree", "Degree"},
			{"CreatedDate", "CreatedDate"}
		};

		protected static new Dictionary<String, String> mappingTableField = new Dictionary<String, String>()
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
			{"Id", "CMND"},
			{"IssuedPlace", "NoiCap"},
			{"Job", "NgheNghiep"},
			{"Degree", "TrinhDo"},
			{"CreatedDate", "NgayTao"}
		};

		public static new Dictionary<string, string> getMapping()
		{
			return mappingParams;
		}

		public static new void setMapping(string key, string value)
		{
			mappingParams.Add(key, value);
		}

		public static new List<AdultDTO> readDatabaseData(SqlDataReader r)
		{
			List<AdultDTO> readerList = new List<AdultDTO>();

			while (r.Read())
			{
				AdultDTO reader = new AdultDTO();
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
