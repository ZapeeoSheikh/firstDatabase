namespace WebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myapptest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Depertments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Teachers = c.Int(nullable: false),
                        Students = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Section = c.String(),
                        Numberofstudent = c.Int(nullable: false),
                        RegularStudent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ProjectStatus", "Marks", c => c.Int(nullable: false));
            AddColumn("dbo.Userdetails", "UserProjectName", c => c.String());
            AddColumn("dbo.Userdetails", "age", c => c.Int(nullable: false));
            AddColumn("dbo.Userdetails", "Numberofpeople", c => c.Int(nullable: false));
            DropColumn("dbo.Userdetails", "ProjectName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Userdetails", "ProjectName", c => c.String());
            DropColumn("dbo.Userdetails", "Numberofpeople");
            DropColumn("dbo.Userdetails", "age");
            DropColumn("dbo.Userdetails", "UserProjectName");
            DropColumn("dbo.ProjectStatus", "Marks");
            DropTable("dbo.Semesters");
            DropTable("dbo.Depertments");
        }
    }
}
