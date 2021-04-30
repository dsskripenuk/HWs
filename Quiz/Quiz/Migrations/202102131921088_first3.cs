namespace Quiz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblAnswer", "Question_Id", "dbo.tblQuestion");
            DropIndex("dbo.tblAnswer", new[] { "Question_Id" });
            AddColumn("dbo.tblQuestion", "asnw1_Id", c => c.Int(nullable: false));
            AddColumn("dbo.tblQuestion", "asnw2_Id", c => c.Int(nullable: false));
            AddColumn("dbo.tblQuestion", "asnw3_Id", c => c.Int(nullable: false));
            AddColumn("dbo.tblQuestion", "asnw4_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.tblQuestion", "asnw1_Id");
            CreateIndex("dbo.tblQuestion", "asnw2_Id");
            CreateIndex("dbo.tblQuestion", "asnw3_Id");
            CreateIndex("dbo.tblQuestion", "asnw4_Id");
            AddForeignKey("dbo.tblQuestion", "asnw1_Id", "dbo.tblAnswer", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblQuestion", "asnw2_Id", "dbo.tblAnswer", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblQuestion", "asnw3_Id", "dbo.tblAnswer", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblQuestion", "asnw4_Id", "dbo.tblAnswer", "Id", cascadeDelete: true);
            DropColumn("dbo.tblAnswer", "Question_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblAnswer", "Question_Id", c => c.Int());
            DropForeignKey("dbo.tblQuestion", "asnw4_Id", "dbo.tblAnswer");
            DropForeignKey("dbo.tblQuestion", "asnw3_Id", "dbo.tblAnswer");
            DropForeignKey("dbo.tblQuestion", "asnw2_Id", "dbo.tblAnswer");
            DropForeignKey("dbo.tblQuestion", "asnw1_Id", "dbo.tblAnswer");
            DropIndex("dbo.tblQuestion", new[] { "asnw4_Id" });
            DropIndex("dbo.tblQuestion", new[] { "asnw3_Id" });
            DropIndex("dbo.tblQuestion", new[] { "asnw2_Id" });
            DropIndex("dbo.tblQuestion", new[] { "asnw1_Id" });
            DropColumn("dbo.tblQuestion", "asnw4_Id");
            DropColumn("dbo.tblQuestion", "asnw3_Id");
            DropColumn("dbo.tblQuestion", "asnw2_Id");
            DropColumn("dbo.tblQuestion", "asnw1_Id");
            CreateIndex("dbo.tblAnswer", "Question_Id");
            AddForeignKey("dbo.tblAnswer", "Question_Id", "dbo.tblQuestion", "Id");
        }
    }
}
