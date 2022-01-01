using Server.DAO;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BUS
{
    public class TagBUS : BUS<TagDTO>
    {
        public override bool delete(string key)
        {
            throw new NotImplementedException();
        }

        public override bool store(TagDTO data)
        {
            throw new NotImplementedException();
        }

        public override bool update(TagDTO data)
        {
            throw new NotImplementedException();
        }

        public List<TagDTO> getAllTag()
        {
            return TagDAO.instance.getAll();
        }
    }
}