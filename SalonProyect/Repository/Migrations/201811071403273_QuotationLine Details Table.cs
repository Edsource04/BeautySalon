namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuotationLineDetailsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuotationLine",
                c => new
                    {
                        QuotationLineId = c.Int(nullable: false, identity: true),
                        QuotationId = c.Int(nullable: false),
                        ProductName = c.String(),
                        EntryDate = c.DateTime(nullable: false),
                        ProductCount = c.Int(nullable: false),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ITBIS = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.QuotationLineId)
                .ForeignKey("dbo.Quotation", t => t.QuotationId, cascadeDelete: true)
                .Index(t => t.QuotationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuotationLine", "QuotationId", "dbo.Quotation");
            DropIndex("dbo.QuotationLine", new[] { "QuotationId" });
            DropTable("dbo.QuotationLine");
        }
    }
}
