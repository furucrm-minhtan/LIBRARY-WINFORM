using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Server.Utils
{
    public class SMTPMail
    {
        protected SmtpClient SC;
        protected string SendMail;
        protected string Subject;
        protected string Body;
        protected List<string> Recipients;
        public SMTPMail(string sendMail)
        {
            this.SendMail = sendMail;
            this.SC = new SmtpClient();
        }

        public void setSubject(string subject)
        {
            this.Subject = subject;
        }

        public void setBody(string body)
        {
            this.Body = body;
        }

        public void setRecipients(List<string> recipients)
        {
            this.Recipients = recipients;
        }

        public bool send()
        {
            try
            {
                SC.Send(this.SendMail, String.Join(";", this.Recipients), this.Subject, this.Body);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }
    }
}
