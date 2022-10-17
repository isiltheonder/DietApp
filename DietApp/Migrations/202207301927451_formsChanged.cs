namespace DietApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class formsChanged : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FoodID = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PicturePath = c.String(),
                        Name = c.String(nullable: false, maxLength: 50),
                        Calorie = c.Double(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        DietFoodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.DietFoods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FoodID = c.Int(nullable: false),
                        DietID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Diets", t => t.DietID, cascadeDelete: true)
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .Index(t => t.FoodID)
                .Index(t => t.DietID);
            
            CreateTable(
                "dbo.Diets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        DietFoodID = c.Int(nullable: false),
                        TotalCalories = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Meal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false),
                        UserDetailID = c.Int(),
                        SecurityQuestion = c.String(nullable: false),
                        SecurityAnswer = c.String(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        AccountCreationDate = c.DateTime(nullable: false),
                        DietID = c.Int(),
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
            DropForeignKey("dbo.Foods", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.DietFoods", "FoodID", "dbo.Foods");
            DropForeignKey("dbo.DietFoods", "DietID", "dbo.Diets");
            DropForeignKey("dbo.Diets", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserDetails", "UserID", "dbo.Users");
            DropIndex("dbo.UserDetails", new[] { "UserID" });
            DropIndex("dbo.Diets", new[] { "UserID" });
            DropIndex("dbo.DietFoods", new[] { "DietID" });
            DropIndex("dbo.DietFoods", new[] { "FoodID" });
            DropIndex("dbo.Foods", new[] { "CategoryID" });
            DropTable("dbo.UserDetails");
            DropTable("dbo.Users");
            DropTable("dbo.Diets");
            DropTable("dbo.DietFoods");
            DropTable("dbo.Foods");
            DropTable("dbo.Categories");
        }
    }
}
