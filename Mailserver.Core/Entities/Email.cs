using Mailserver.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailserver.Core.Entities
{
    public class Email : BaseEntity
    {
        public string Body { get; set; }
    }
}
