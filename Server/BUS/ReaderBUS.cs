using Server.DAO;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Utils;

namespace Server.BUS
{
    public class ReaderBUS : BUS<ReaderDTO>
    {
        protected SMTPMail mail;

        public ReaderBUS()
        {
            this.mail = new SMTPMail("demonblack789@gmail.com");
        }

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
                string password = Helpers.getRandomString(10);
                data.Password = Helpers.hashPassword(Helpers.getRandomString(10));
                if (ReaderDAO.instance.insert(data))
                {
                    mail.setBody($"password: {password}");
                    mail.setSubject($"Đăng Ký Thành Viên Thư Viện Thành Công");
                    mail.setRecipients(new List<string> { data.Email });
                    mail.send();
                    return true;
                }
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

        public List<ReaderDTO> getAllReader()
        {
            return ReaderDAO.instance.getAll();
        }
    }
}
