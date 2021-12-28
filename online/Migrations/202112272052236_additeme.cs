namespace online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class additeme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item_Name = c.String(nullable: false),
                        ISdisable = c.Boolean(nullable: false),
                        Type = c.String(),
                        Qty = c.Int(nullable: false),
                        Color = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Size = c.String(),
                        FirstQty = c.Int(nullable: false),
                        StoreId = c.Int(),
                        RatingId = c.Int(),
                        Img_Path = c.String(),
                        Offers_type = c.String(),
                        Class_Offers = c.String(),
                        UserId = c.Int(nullable: false),
                        Description_N1Id = c.Int(nullable: false),
                        Description_N2Id = c.Int(),
                        Description_N3Id = c.Int(),
                        Date_Record = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Description_N1", t => t.Description_N1Id, cascadeDelete: true)
                .ForeignKey("dbo.Description_N2", t => t.Description_N2Id)
                .ForeignKey("dbo.Description_N3", t => t.Description_N3Id)
                .ForeignKey("dbo.Ratings", t => t.RatingId)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.StoreId)
                .Index(t => t.RatingId)
                .Index(t => t.UserId)
                .Index(t => t.Description_N1Id)
                .Index(t => t.Description_N2Id)
                .Index(t => t.Description_N3Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "UserId", "dbo.Users");
            DropForeignKey("dbo.Items", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Items", "RatingId", "dbo.Ratings");
            DropForeignKey("dbo.Items", "Description_N3Id", "dbo.Description_N3");
            DropForeignKey("dbo.Items", "Description_N2Id", "dbo.Description_N2");
            DropForeignKey("dbo.Items", "Description_N1Id", "dbo.Description_N1");
            DropIndex("dbo.Items", new[] { "Description_N3Id" });
            DropIndex("dbo.Items", new[] { "Description_N2Id" });
            DropIndex("dbo.Items", new[] { "Description_N1Id" });
            DropIndex("dbo.Items", new[] { "UserId" });
            DropIndex("dbo.Items", new[] { "RatingId" });
            DropIndex("dbo.Items", new[] { "StoreId" });
            DropTable("dbo.Items");
        }
    }
}
