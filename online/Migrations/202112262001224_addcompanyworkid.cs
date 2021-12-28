namespace online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcompanyworkid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Company_WorkId", c => c.Int(nullable: false));
            CreateIndex("dbo.Companies", "Company_WorkId");
            AddForeignKey("dbo.Companies", "Company_WorkId", "dbo.Company_Work", "ID", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "Company_WorkId", "dbo.Company_Work");
            DropIndex("dbo.Companies", new[] { "Company_WorkId" });
            DropColumn("dbo.Companies", "Company_WorkId");
        }
    }
}
