namespace MVC_EF_Template.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Grade = c.Int(),
                        Student_ID = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectID)
                .ForeignKey("dbo.Students", t => t.Student_ID)
                .Index(t => t.Student_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "Student_ID", "dbo.Students");
            DropIndex("dbo.Subjects", new[] { "Student_ID" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
        }
    }
}
