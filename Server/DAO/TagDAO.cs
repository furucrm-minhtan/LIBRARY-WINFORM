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
    public class TagDAO : DAO<TagDTO>
    {
        public static TagDAO instance = new TagDAO();
        public override string table => "Muc";

        public override bool delete(string key)
        {
            throw new NotImplementedException();
        }

        public override List<TagDTO> getAll()
        {
            List<TagDTO> rs = new List<TagDTO>();

            Database.excuteQuery((SqlConnection con) =>
            {
                SqlCommand cm = new SqlCommand("GetTags", con);
                cm.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cm.ExecuteReader();

                rs = TagDTO.readDatabaseData(reader);
            });

            return rs;
        }

        public override bool insert(TagDTO data)
        {
            throw new NotImplementedException();
        }

        public override bool update(TagDTO data)
        {
            throw new NotImplementedException();
        }
    }
}
