namespace EmployeeManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNo = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Department_Id = c.Int(),
                        Designation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .ForeignKey("dbo.Designations", t => t.Designation_Id)
                .Index(t => t.Department_Id)
                .Index(t => t.Designation_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Designation_Id", "dbo.Designations");
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Designation_Id" });
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Designations");
            DropTable("dbo.Departments");
        }
    }
}
