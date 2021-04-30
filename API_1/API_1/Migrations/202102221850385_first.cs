namespace API_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblBloggers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Subscribers = c.Int(nullable: false),
                        Platform = c.String(nullable: false),
                        AudienceAge = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        Image = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblCategory", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.tblCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblBloggers", "CategoryId", "dbo.tblCategory");
            DropIndex("dbo.tblBloggers", new[] { "CategoryId" });
            DropTable("dbo.tblCategory");
            DropTable("dbo.tblBloggers");
        }
    }
}
