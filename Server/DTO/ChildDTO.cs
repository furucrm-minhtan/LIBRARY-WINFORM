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
	public class ChildDTO : ReaderDTO {
		public string School { get; set; }
		public string Class { get; set; }
		public ChildDTO Protector { get; set; }

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
			{"School", "School"},
			{"Class", "Class"},
			{"Protector", "Protector"}
		};
	}
}
