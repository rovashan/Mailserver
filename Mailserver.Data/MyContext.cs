using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Mailserver.Core.Entities;

namespace Mailserver.Data
{
    public class MyContext : DbContext
    {

        public MyContext() : base("MydbConn")
        {
            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }

        public virtual DbSet<Email> Emails { get; set; }
    }
}
