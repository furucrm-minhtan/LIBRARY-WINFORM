using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class BookDTO 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
        public string Publish { get; set; }
        public string ISBN { get; set; }
        public string Position { get; set; }
        public string Remain { get; set; }
        public string Tag { get; set; }

		public string CreatedDate { get; set; }

		protected static Dictionary<String, String> mappingParams = new Dictionary<String, String>()
		{
			{"Name", "Name"},
			{"Author", "Author"},
			{"Description", "Description"},
			{"Cover", "Cover"},
			{"Publish", "Publish"},
			{"ISBN", "ISBN"},
			{"Position", "Position"},
			{"Remain", "Remain"},
			{"Tag", "Tag"},
			{"CreatedDate", "CreatedDate"}
		};

		protected static Dictionary<String, String> mappingTableField = new Dictionary<String, String>()
		{
			{"Id", "ma_sach" },
			{"Name", "ten_sach"},
			{"Author", "ten_tac_gia"},
			{"Description", "mo_ta"},
			{"Cover", "trang_bia"},
			{"Publish", "ngay_xuat_ban"},
			{"ISBN", "isbn"},
			{"Position", "vi_tri"},
			{"Remain", "so_luong_ton_kho"},
			{"Tag", "the_loai" },
			{"CreatedDate", "ngay_tao"}
		};

		public static Dictionary<string, string> getMapping()
		{
			return mappingParams;
		}

		public static void setMapping(string key, string value)
		{
			mappingParams.Add(key, value);
		}


		public static List<BookDTO> readDatabaseData(SqlDataReader r)
		{
			List<BookDTO> readerList = new List<BookDTO>();

			while (r.Read())
			{
				BookDTO reader = new BookDTO();
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
