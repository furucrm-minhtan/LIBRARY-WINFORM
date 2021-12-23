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
        public int Remain { get; set; }
        public string Tag { get; set; }

		protected static Dictionary<String, String> mappingField = new Dictionary<String, String>()
		{
			{"Name", "Name"},
			{"Author", "Author"},
			{"Description", "Description"},
			{"Cover", "Cover"},
			{"Publish", "Publish"},
			{"ISBN", "ISBN"},
			{"Position", "Position"},
			{"Remain", "Remain"}
		};

		public static Dictionary<string, string> getMapping()
		{
			return mappingField;
		}


		public static List<BookDTO> readDatabaseData(SqlDataReader r)
		{
			List<BookDTO> readerList = new List<BookDTO>();

			while (r.Read())
			{
				BookDTO reader = new BookDTO();
				foreach (var item in mappingField)
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
