namespace Quiz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAnswer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextAnswer = c.String(nullable: false),
                        isTrue = c.Boolean(nullable: false),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblQuestion", t => t.Question_Id)
                .Index(t => t.Question_Id);
            
            CreateTable(
                "dbo.tblQuestion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextQuestion = c.String(nullable: false),
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
            DropForeignKey("dbo.tblAnswer", "Question_Id", "dbo.tblQuestion");
            DropIndex("dbo.tblQuestion", new[] { "Quiz_Id" });
            DropIndex("dbo.tblAnswer", new[] { "Question_Id" });
            DropTable("dbo.tblQuiz");
            DropTable("dbo.tblQuestion");
            DropTable("dbo.tblAnswer");
        }
    }
}
