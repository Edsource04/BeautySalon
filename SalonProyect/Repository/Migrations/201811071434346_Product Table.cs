namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductCategoryId = c.Int(nullable: false),
                        ProductCode = c.String(),
                        ImageUrl = c.String(),
                        EntryDate = c.DateTime(nullable: false, storeType: "date"),
                        Description = c.String(),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductCount = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        ProviderId = c.Int(nullable: false),
                        Barcode = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategory", t => t.ProductCategoryId)
                .Index(t => t.ProductCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "ProductCategoryId", "dbo.ProductCategory");
            DropIndex("dbo.Product", new[] { "ProductCategoryId" });
            DropTable("dbo.Product");
        }
    }
}
