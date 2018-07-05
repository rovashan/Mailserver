using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mailserver.Core.Entities;

namespace Mailserver.Service.Mail
{
    public class MailService : IMailService
    {
        public IEnumerable<Email> GetMail()
        {
            var mails = new List<Email>();
            var mail = new Email();
            mail.Body = "ola";
            mails.Add(mail);

            return mails;
        }
    }
}
