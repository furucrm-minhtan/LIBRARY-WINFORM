using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class TagDTO
    {
		public string Id { get; set; }
		public string Name { get; set; }

		protected static Dictionary<String, String> mappingTableField = new Dictionary<String, String>()
		{
			{ "Id", "ma_muc" },
			{ "Name", "ten_muc" }
		};

		public static List<TagDTO> readDatabaseData(SqlDataReader r)
		{
			List<TagDTO> tagList = new List<TagDTO>();

			while (r.Read())
			{
				TagDTO tag = new TagDTO();
				foreach (var item in mappingTableField)
				{
					string value = r[item.Value] == null ? "" : r[item.Value].ToString();
					tag.GetType().GetProperty(item.Key).SetValue(tag, value, null);
				}
				tagList.Add(tag);
			}

			return tagList;
		}
	}
}
