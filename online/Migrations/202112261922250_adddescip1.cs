namespace online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddescip1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Description_N1",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description_N1_Name = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                        Date_Record = c.DateTime(nullable: false),
                        ISdisable = c.Boolean(nullable: false),
                        Modify_Date = c.DateTime(),
                        User_ModifyId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_ModifyId)
                .Index(t => t.UserId)
                .Index(t => t.User_ModifyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Description_N1", "User_ModifyId", "dbo.Users");
            DropForeignKey("dbo.Description_N1", "UserId", "dbo.Users");
            DropIndex("dbo.Description_N1", new[] { "User_ModifyId" });
            DropIndex("dbo.Description_N1", new[] { "UserId" });
            DropTable("dbo.Description_N1");
        }
    }
}
