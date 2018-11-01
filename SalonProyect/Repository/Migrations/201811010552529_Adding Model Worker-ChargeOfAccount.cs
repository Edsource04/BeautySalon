namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingModelWorkerChargeOfAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChargeOfAccount",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntryDate = c.DateTime(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientId = c.Int(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                        User = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RemainingAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Worker",
                c => new
                    {
                        WorkerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        Birthday = c.DateTime(nullable: false, storeType: "date"),
                        DocumentNumber = c.String(),
                        Address = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        Status = c.Boolean(nullable: false),
                        InsertedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        InsertedBy = c.String(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.WorkerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChargeOfAccount", "ClientId", "dbo.Client");
            DropIndex("dbo.ChargeOfAccount", new[] { "ClientId" });
            DropTable("dbo.Worker");
            DropTable("dbo.ChargeOfAccount");
        }
    }
}
