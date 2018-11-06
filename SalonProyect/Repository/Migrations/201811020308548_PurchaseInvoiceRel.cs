namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseInvoiceRel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseInvoice",
                c => new
                    {
                        InvoiceId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        Employee = c.String(),
                        PaymentType = c.Int(nullable: false),
                        PaymentMethod = c.Int(nullable: false),
                        PurchaseDate = c.DateTime(nullable: false, storeType: "date"),
                        SalesInvoiceId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        ProductCount = c.Int(nullable: false),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Taxes = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DocumentNo = c.String(),
                    })
                .PrimaryKey(t => t.InvoiceId)
                .ForeignKey("dbo.Client", t => t.ClientId)
                .ForeignKey("dbo.Worker", t => t.EmployeeId)
                .Index(t => t.ClientId)
                .Index(t => t.EmployeeId);
            
            AddColumn("dbo.ChargeOfAccount", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseInvoice", "EmployeeId", "dbo.Worker");
            DropForeignKey("dbo.PurchaseInvoice", "ClientId", "dbo.Client");
            DropIndex("dbo.PurchaseInvoice", new[] { "EmployeeId" });
            DropIndex("dbo.PurchaseInvoice", new[] { "ClientId" });
            DropColumn("dbo.ChargeOfAccount", "Status");
            DropTable("dbo.PurchaseInvoice");
        }
    }
}
