namespace online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddescip2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Description_N2", "User_ModifyId", "dbo.Users");
            DropIndex("dbo.Description_N2", new[] { "User_ModifyId" });
            AlterColumn("dbo.Description_N2", "User_ModifyId", c => c.Int());
            CreateIndex("dbo.Description_N2", "User_ModifyId");
            AddForeignKey("dbo.Description_N2", "User_ModifyId", "dbo.Users", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Description_N2", "User_ModifyId", "dbo.Users");
            DropIndex("dbo.Description_N2", new[] { "User_ModifyId" });
            AlterColumn("dbo.Description_N2", "User_ModifyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Description_N2", "User_ModifyId");
            AddForeignKey("dbo.Description_N2", "User_ModifyId", "dbo.Users", "ID", cascadeDelete: true);
        }
    }
}
