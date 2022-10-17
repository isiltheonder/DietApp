namespace DietApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bininciMigration : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Foods", name: "Picture_ID", newName: "PictureID");
            RenameIndex(table: "dbo.Foods", name: "IX_Picture_ID", newName: "IX_PictureID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Foods", name: "IX_PictureID", newName: "IX_Picture_ID");
            RenameColumn(table: "dbo.Foods", name: "PictureID", newName: "Picture_ID");
        }
    }
}
