namespace online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGrouprate : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Groups", "User_ModifyId");
            CreateIndex("dbo.Ratings", "User_ModifyId");
            AddForeignKey("dbo.Groups", "User_ModifyId", "dbo.Users", "ID");
            AddForeignKey("dbo.Ratings", "User_ModifyId", "dbo.Users", "ID");
            DropColumn("dbo.Groups", "User_Modify");
            DropColumn("dbo.Ratings", "User_Modify");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ratings", "User_Modify", c => c.Int(nullable: false));
            AddColumn("dbo.Groups", "User_Modify", c => c.Int(nullable: false));
            DropForeignKey("dbo.Ratings", "User_ModifyId", "dbo.Users");
            DropForeignKey("dbo.Groups", "User_ModifyId", "dbo.Users");
            DropIndex("dbo.Ratings", new[] { "User_ModifyId" });
            DropIndex("dbo.Groups", new[] { "User_ModifyId" });
        }
    }
}
