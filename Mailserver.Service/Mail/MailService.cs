using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mailserver.Core.Entities;
using Mailserver.Data;

namespace Mailserver.Service.Mail
{
    public class MailService : IMailService
    {
        public IEnumerable<Email> GetMailByLabel(string label)
        {
            using (var db = new MyContext())
            {
                var mailLabel = label.ToLower();
                var mails = db.Emails.Where(x => x.Label == mailLabel).ToList();
                return mails;
            }
        }
    }
}
