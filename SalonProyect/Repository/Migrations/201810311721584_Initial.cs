namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        IdClient = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        Birthday = c.DateTime(storeType: "date"),
                        DocumentType = c.String(),
                        DocumentNumber = c.String(),
                        Address = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        Status = c.Boolean(nullable: false),
                        ClientCode = c.String(),
                        InsertedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: true),
                        InsertedBy = c.String(),
                        ModifiedBy = c.String(),
                        HostName = c.String(),
                    })
                .PrimaryKey(t => t.IdClient);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Client");
        }
    }
}
