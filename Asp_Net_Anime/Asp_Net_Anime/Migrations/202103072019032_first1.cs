namespace Asp_Net_Anime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblEpisodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Season = c.Int(nullable: false),
                        Img_URL = c.String(nullable: false),
                        Video_URL = c.String(nullable: false),
                        AnimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblAnime", t => t.AnimeId, cascadeDelete: true)
                .Index(t => t.AnimeId);
            
            CreateTable(
                "dbo.tblScreenshots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(nullable: false),
                        AnimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblAnime", t => t.AnimeId, cascadeDelete: true)
                .Index(t => t.AnimeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblScreenshots", "AnimeId", "dbo.tblAnime");
            DropForeignKey("dbo.tblEpisodes", "AnimeId", "dbo.tblAnime");
            DropIndex("dbo.tblScreenshots", new[] { "AnimeId" });
            DropIndex("dbo.tblEpisodes", new[] { "AnimeId" });
            DropTable("dbo.tblScreenshots");
            DropTable("dbo.tblEpisodes");
        }
    }
}
