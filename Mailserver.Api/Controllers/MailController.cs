using Mailserver.Core.Entities;
using Mailserver.Service.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Mailserver.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MailController : ApiController
    {
        private readonly IMailService mailService;

        public MailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        public IEnumerable<Email> Get(string label)
        {
            return mailService.GetMailByLabel(label);
        }
    }
}
