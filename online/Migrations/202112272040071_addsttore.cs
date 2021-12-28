namespace online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsttore : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Store_Name = c.String(nullable: false),
                        Address = c.String(),
                        Master = c.Boolean(nullable: false),
                        Serial_ADD = c.Int(nullable: false),
                        Serial_Return = c.Int(nullable: false),
                        Serial_Return_Sell = c.Int(nullable: false),
                        Serial_Sell = c.Int(nullable: false),
                        Serial_Transferin = c.Int(nullable: false),
                        Serial_Transferout = c.Int(nullable: false),
                        Serial_AddJ_Plus = c.Int(nullable: false),
                        Serial_Addj_Discount = c.Int(nullable: false),
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
            DropForeignKey("dbo.Stores", "User_ModifyId", "dbo.Users");
            DropForeignKey("dbo.Stores", "UserId", "dbo.Users");
            DropIndex("dbo.Stores", new[] { "User_ModifyId" });
            DropIndex("dbo.Stores", new[] { "UserId" });
            DropTable("dbo.Stores");
        }
    }
}
