namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalePurchaseRel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChargeOfAccount", "Sale_SaleInvoiceId", c => c.Int());
            AddColumn("dbo.PurchaseInvoice", "Sale_SaleInvoiceId", c => c.Int());
            CreateIndex("dbo.ChargeOfAccount", "Sale_SaleInvoiceId");
            CreateIndex("dbo.PurchaseInvoice", "Sale_SaleInvoiceId");
            AddForeignKey("dbo.PurchaseInvoice", "Sale_SaleInvoiceId", "dbo.SaleInvoice", "SaleInvoiceId");
            AddForeignKey("dbo.ChargeOfAccount", "Sale_SaleInvoiceId", "dbo.SaleInvoice", "SaleInvoiceId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChargeOfAccount", "Sale_SaleInvoiceId", "dbo.SaleInvoice");
            DropForeignKey("dbo.PurchaseInvoice", "Sale_SaleInvoiceId", "dbo.SaleInvoice");
            DropIndex("dbo.PurchaseInvoice", new[] { "Sale_SaleInvoiceId" });
            DropIndex("dbo.ChargeOfAccount", new[] { "Sale_SaleInvoiceId" });
            DropColumn("dbo.PurchaseInvoice", "Sale_SaleInvoiceId");
            DropColumn("dbo.ChargeOfAccount", "Sale_SaleInvoiceId");
        }
    }
}
