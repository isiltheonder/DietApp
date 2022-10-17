namespace DietApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class binbirinciMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pictures", "Path", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pictures", "Path", c => c.String(nullable: false));
        }
    }
}
