namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SaleInvoice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaleInvoice",
                c => new
                    {
                        SaleInvoiceId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        WorkerId = c.Int(nullable: false),
                        SalesDate = c.DateTime(nullable: false, storeType: "date"),
                        PaymentType = c.Int(nullable: false),
                        ClientType = c.Int(nullable: false),
                        SaleType = c.String(),
                        ITBIS = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Subtotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SaleInvoiceId)
                .ForeignKey("dbo.Client", t => t.ClientId)
                .ForeignKey("dbo.Worker", t => t.WorkerId)
                .Index(t => t.ClientId)
                .Index(t => t.WorkerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleInvoice", "WorkerId", "dbo.Worker");
            DropForeignKey("dbo.SaleInvoice", "ClientId", "dbo.Client");
            DropIndex("dbo.SaleInvoice", new[] { "WorkerId" });
            DropIndex("dbo.SaleInvoice", new[] { "ClientId" });
            DropTable("dbo.SaleInvoice");
        }
    }
}
