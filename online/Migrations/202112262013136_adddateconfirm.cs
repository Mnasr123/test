namespace online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddateconfirm : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Date_Confirm", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Date_Confirm", c => c.DateTime(nullable: false));
        }
    }
}
