namespace online.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddetailsitems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Item_details",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        ISdisable = c.Boolean(nullable: false),
                        Qty = c.Int(nullable: false),
                        Color = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Size = c.String(),
                        FirstQty = c.Int(nullable: false),
                        StoreId = c.Int(),
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
                .ForeignKey("dbo.Description_N1", t => t.Description_N1Id, cascadeDelete: false)
                .ForeignKey("dbo.Description_N2", t => t.Description_N2Id)
                .ForeignKey("dbo.Description_N3", t => t.Description_N3Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.ItemId)
                .Index(t => t.StoreId)
                .Index(t => t.UserId)
                .Index(t => t.Description_N1Id)
                .Index(t => t.Description_N2Id)
                .Index(t => t.Description_N3Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item_details", "UserId", "dbo.Users");
            DropForeignKey("dbo.Item_details", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Item_details", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Item_details", "Description_N3Id", "dbo.Description_N3");
            DropForeignKey("dbo.Item_details", "Description_N2Id", "dbo.Description_N2");
            DropForeignKey("dbo.Item_details", "Description_N1Id", "dbo.Description_N1");
            DropIndex("dbo.Item_details", new[] { "Description_N3Id" });
            DropIndex("dbo.Item_details", new[] { "Description_N2Id" });
            DropIndex("dbo.Item_details", new[] { "Description_N1Id" });
            DropIndex("dbo.Item_details", new[] { "UserId" });
            DropIndex("dbo.Item_details", new[] { "StoreId" });
            DropIndex("dbo.Item_details", new[] { "ItemId" });
            DropTable("dbo.Item_details");
        }
    }
}
