namespace DietApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databaseCreationAndAdminAddition : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Diets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        FoodID = c.Int(nullable: false),
                        TotalCalories = c.Double(nullable: false),
                        Meal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Calorie = c.Double(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        Diet_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Diets", t => t.Diet_ID)
                .Index(t => t.CategoryID)
                .Index(t => t.Diet_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false),
                        UserDetailID = c.Int(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        AccountCreationDate = c.DateTime(nullable: false),
                        DietID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Gender = c.Int(nullable: false),
                        Weight = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Diets", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserDetails", "UserID", "dbo.Users");
            DropForeignKey("dbo.Foods", "Diet_ID", "dbo.Diets");
            DropForeignKey("dbo.Foods", "CategoryID", "dbo.Categories");
            DropIndex("dbo.UserDetails", new[] { "UserID" });
            DropIndex("dbo.Foods", new[] { "Diet_ID" });
            DropIndex("dbo.Foods", new[] { "CategoryID" });
            DropIndex("dbo.Diets", new[] { "UserID" });
            DropTable("dbo.UserDetails");
            DropTable("dbo.Users");
            DropTable("dbo.Foods");
            DropTable("dbo.Diets");
            DropTable("dbo.Categories");
        }
    }
}
