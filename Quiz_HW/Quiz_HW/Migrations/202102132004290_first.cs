namespace Quiz_HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblQuestion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextQuestion = c.String(nullable: false),
                        asnw1 = c.String(nullable: false),
                        asnw2 = c.String(nullable: false),
                        asnw3 = c.String(nullable: false),
                        asnw4 = c.String(nullable: false),
                        Quiz_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblQuiz", t => t.Quiz_Id)
                .Index(t => t.Quiz_Id);
            
            CreateTable(
                "dbo.tblQuiz",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblQuestion", "Quiz_Id", "dbo.tblQuiz");
            DropIndex("dbo.tblQuestion", new[] { "Quiz_Id" });
            DropTable("dbo.tblQuiz");
            DropTable("dbo.tblQuestion");
        }
    }
}
