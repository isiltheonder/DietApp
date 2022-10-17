namespace DietApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dietDateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Diets", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Diets", "Date");
        }
    }
}
