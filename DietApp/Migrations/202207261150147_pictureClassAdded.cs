namespace DietApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pictureClassAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Foods", "Picture_ID", c => c.Int());
            CreateIndex("dbo.Foods", "Picture_ID");
            AddForeignKey("dbo.Foods", "Picture_ID", "dbo.Pictures", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "Picture_ID", "dbo.Pictures");
            DropIndex("dbo.Foods", new[] { "Picture_ID" });
            DropColumn("dbo.Foods", "Picture_ID");
            DropTable("dbo.Pictures");
        }
    }
}
