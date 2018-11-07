namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuotationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quotation",
                c => new
                    {
                        QuotationId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        WorkerId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ITBIS = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.QuotationId)
                .ForeignKey("dbo.Client", t => t.ClientId)
                .ForeignKey("dbo.Worker", t => t.WorkerId)
                .Index(t => t.ClientId)
                .Index(t => t.WorkerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quotation", "WorkerId", "dbo.Worker");
            DropForeignKey("dbo.Quotation", "ClientId", "dbo.Client");
            DropIndex("dbo.Quotation", new[] { "WorkerId" });
            DropIndex("dbo.Quotation", new[] { "ClientId" });
            DropTable("dbo.Quotation");
        }
    }
}
