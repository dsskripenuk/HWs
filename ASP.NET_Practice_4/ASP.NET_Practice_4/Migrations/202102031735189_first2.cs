namespace ASP.NET_Practice_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblFilms",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        DateOfRelease = c.String(nullable: false),
                        Rating = c.Int(nullable: false),
                        URL_Image = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblFilms");
        }
    }
}
