namespace DietApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class securityDetailAddition : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "SecurityQuestion", c => c.String(nullable: false));
            AddColumn("dbo.Users", "SecurityAnswer", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "SecurityAnswer");
            DropColumn("dbo.Users", "SecurityQuestion");
        }
    }
}
