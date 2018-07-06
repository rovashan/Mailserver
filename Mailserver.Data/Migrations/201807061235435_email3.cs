namespace Mailserver.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class email3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Emails", "EmailDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Emails", "EmailDate");
        }
    }
}
