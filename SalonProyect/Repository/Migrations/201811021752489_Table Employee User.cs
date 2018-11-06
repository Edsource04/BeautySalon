namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableEmployeeUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        AssigmentDate = c.DateTime(),
                        DeAssigmentDate = c.DateTime(),
                        AssignationStatus = c.Boolean(nullable: false),
                        InsertedBy = c.String(),
                        ModifiedBy = c.String(),
                        InsertedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        User_Id = c.Int(),
                        Employee_WorkerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .ForeignKey("dbo.Worker", t => t.Employee_WorkerId)
                .Index(t => t.User_Id)
                .Index(t => t.Employee_WorkerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeUser", "Employee_WorkerId", "dbo.Worker");
            DropForeignKey("dbo.EmployeeUser", "User_Id", "dbo.User");
            DropIndex("dbo.EmployeeUser", new[] { "Employee_WorkerId" });
            DropIndex("dbo.EmployeeUser", new[] { "User_Id" });
            DropTable("dbo.EmployeeUser");
        }
    }
}
