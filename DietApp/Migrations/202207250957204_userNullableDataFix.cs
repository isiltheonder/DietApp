namespace DietApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userNullableDataFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserDetailID", c => c.Int());
            AlterColumn("dbo.Users", "DietID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "DietID", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "UserDetailID", c => c.Int(nullable: false));
        }
    }
}
