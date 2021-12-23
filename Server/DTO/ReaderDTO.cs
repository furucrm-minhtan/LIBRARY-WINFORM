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

		protected static Dictionary<String, String> mappingField = new Dictionary<String, String>()
		{
			{"DisplayName", "DisplayName"},
			{"UserName", "UserName"},
			{"Password", "Password"},
			{"Birth", "Birth"},
			{"Email", "Email"},
			{"Sex", "Sex"},
			{"Avatar", "Avatar"},
			{"PhoneNumber", "PhoneNumber"},
			{"Nation", "Nation"},
			{"Nationality", "Nationality"},
			{"Type", "Type"}
		};

		public static Dictionary<string, string> getMapping()
        {
			return mappingField;
        }


		public static List<ReaderDTO> readDatabaseData(SqlDataReader r)
        {
			List<ReaderDTO> readerList = new List<ReaderDTO>();

			while(r.Read())
            {
				ReaderDTO reader = new ReaderDTO();
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
