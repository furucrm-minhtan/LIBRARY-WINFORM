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
	public class ChildDTO : ReaderDTO {
		public string School { get; set; }
		public string Class { get; set; }
		public string Protector { get; set; }
        public new string getReaderType => ReaderType.Child.ToString();

        protected static new Dictionary<String, String> mappingParams = new Dictionary<String, String>()
		{
			{"DisplayName", "DisplayName"},
			{"UserName", "UserName"},
			{"Password", "Password"},
			{"Birth", "Birth"},
			{"Email", "Email"},
			{"Sex", "Sex"},
			{"Avatar", "Avatar"},
			{"PhoneNumber", "PhoneNumber"},
			{"School", "School"},
			{"Class", "Class"},
			{"Protector", "Protector"},
			{"CreatedDate", "CreatedDate"}
		};

		protected static new Dictionary<String, String> mappingTableField = new Dictionary<String, String>()
		{
			{"MADG", "ma_doc_gia" },
			{"DisplayName", "ten_doc_gia"},
			{"UserName", "ten_dang_nhap"},
			{"Password", "mat_khau"},
			{"Birth", "ngay_sinh"},
			{"Email", "email"},
			{"Sex", "gioi_tinh"},
			{"Avatar", "anh_dai_dien"},
			{"PhoneNumber", "so_dien_thoai"},
			{"Nation", "dan_toc"},
			{"Nationality", "quoc_tinh"},
			{"Type", "loai"},
			{"CreatedDate", "ngay_tao"},
			{"School", "truong"},
			{"Class", "lop"},
			{"Protector", "nguoi_giam_ho"}
		};

		public static new Dictionary<string, string> getMapping()
		{
			return mappingParams;
		}

		public static new void setMapping(string key, string value)
		{
            mappingParams.Add(key, value);
		}

		public static new List<ChildDTO> readDatabaseData(SqlDataReader r)
		{
			List<ChildDTO> readerList = new List<ChildDTO>();

			while (r.Read())
			{
				ChildDTO reader = new ChildDTO();
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
