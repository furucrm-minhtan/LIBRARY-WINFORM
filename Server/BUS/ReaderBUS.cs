using Server.DAO;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BUS
{
    public class ReaderBUS : BUS<ReaderDTO>
    {
        public override bool delete(string key)
        {
            try
            {
                ReaderDAO.instance.delete(key);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public override bool store(ReaderDTO data)
        {
            try
            {
                ReaderDAO.instance.insert(data);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public override bool update(ReaderDTO data)
        {
            try
            {
                ReaderDAO.instance.update(data);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
