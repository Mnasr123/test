namespace online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGrouprating : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Group_Name = c.String(nullable: false),
                        Description_Data = c.String(),
                        UserId = c.Int(nullable: false),
                        Date_Record = c.DateTime(nullable: false),
                        ISdisable = c.Boolean(nullable: false),
                        Modify_Date = c.DateTime(),
                        User_Modify = c.Int(nullable: false),
                        User_ModifyId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Rating_Name = c.String(nullable: false),
                        Description_Data = c.String(),
                        GroupId = c.Int(nullable: false),
                        Offers = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                        Date_Record = c.DateTime(nullable: false),
                        ISdisable = c.Boolean(nullable: false),
                        Modify_Date = c.DateTime(),
                        User_Modify = c.Int(nullable: false),
                        User_ModifyId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.GroupId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ratings", "UserId", "dbo.Users");
            DropForeignKey("dbo.Ratings", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Groups", "UserId", "dbo.Users");
            DropIndex("dbo.Ratings", new[] { "UserId" });
            DropIndex("dbo.Ratings", new[] { "GroupId" });
            DropIndex("dbo.Groups", new[] { "UserId" });
            DropTable("dbo.Ratings");
            DropTable("dbo.Groups");
        }
    }
}
