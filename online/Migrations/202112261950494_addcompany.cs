namespace online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Company_name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Tele = c.String(),
                        Mobile = c.String(),
                        ComertialRegister = c.String(),
                        Tax_Register = c.String(),
                        Socialnum = c.String(),
                        Comp_TypeId = c.Int(nullable: false),
                        Image = c.String(),
                        Master = c.Boolean(nullable: false),
                        Web = c.String(),
                        Fax = c.String(),
                        Post_email = c.String(),
                        Passward = c.String(),
                        Manager_Name = c.String(),
                        Manager_address = c.String(),
                        Idtax = c.String(),
                        Host = c.String(),
                        Postcode = c.String(),
                        UserId = c.Int(nullable: false),
                        Isavaliable = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Company_Type", t => t.Comp_TypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.Comp_TypeId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "UserId", "dbo.Users");
            DropForeignKey("dbo.Companies", "Comp_TypeId", "dbo.Company_Type");
            DropIndex("dbo.Companies", new[] { "UserId" });
            DropIndex("dbo.Companies", new[] { "Comp_TypeId" });
            DropTable("dbo.Companies");
        }
    }
}
