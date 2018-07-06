namespace Mailserver.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mailserver.Data.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Mailserver.Data.MyContext";
        }

        protected override void Seed(Mailserver.Data.MyContext context)
        {
            IList<Mailserver.Core.Entities.Email> emails = new List<Mailserver.Core.Entities.Email>();

            emails.Add(new Mailserver.Core.Entities.Email()
            {
                Subject = "Meeting",
                Body = "Design Session",
                From = "ronaldo@gmail.com",
                To = "messi@gmail.com",
                Label = "inbox",
                EmailDate = DateTime.Now
            });

            emails.Add(new Mailserver.Core.Entities.Email()
            {
                Subject = "Stand up",
                Body = "Every day at 1 pm",
                From = "ronaldo@gmail.com",
                To = "messi@gmail.com",
                Label = "drafts",
                EmailDate = DateTime.Now
            });

            emails.Add(new Mailserver.Core.Entities.Email()
            {
                Subject = "Braai",
                Body = "On the roof at 3pm",
                From = "ronaldo@gmail.com",
                To = "messi@gmail.com",
                Label = "sent",
                EmailDate = DateTime.Now
            });

            emails.Add(new Mailserver.Core.Entities.Email()
            {
                Subject = "Training",
                Body = "Angular PWA training",
                From = "ronaldo@gmail.com",
                To = "messi@gmail.com",
                Label = "outbox",
                EmailDate = DateTime.Now
            });

            emails.Add(new Mailserver.Core.Entities.Email()
            {
                Subject = "Goals",
                Body = "What are our goals for 2018?",
                From = "ronaldo@gmail.com",
                To = "messi@gmail.com",
                Label = "trash",
                EmailDate = DateTime.Now
            });

            context.Emails.AddRange(emails);

            base.Seed(context);
        }
    }
}
