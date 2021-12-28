namespace online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcompanywork : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company_Type",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type_name = c.String(nullable: false),
                        Isavaliable = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Company_Work",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Work_name = c.String(nullable: false),
                        Isavaliable = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Company_Work", "UserId", "dbo.Users");
            DropForeignKey("dbo.Company_Type", "UserId", "dbo.Users");
            DropIndex("dbo.Company_Work", new[] { "UserId" });
            DropIndex("dbo.Company_Type", new[] { "UserId" });
            DropTable("dbo.Company_Work");
            DropTable("dbo.Company_Type");
        }
    }
}
