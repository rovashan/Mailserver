using Mailserver.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailserver.Service.Mail
{
    public interface IMailService
    {
        IEnumerable<Email> GetMail();
    }
}
