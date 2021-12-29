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

        protected static new Dictionary<String, String> mappingField = new Dictionary<String, String>()
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
			{"Id", "Id"},
			{"IssuedPlace", "IssuedPlace"},
			{"Job", "Job"},
			{"Degree", "Degree"},
			{"CreatedDate", "CreatedDate"}
		};

		public static Dictionary<string, string> getMapping()
		{
			return mappingField;
		}
	}
}
