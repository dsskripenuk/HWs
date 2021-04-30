namespace ASP.NET_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblGames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Developer = c.String(nullable: false),
                        Price = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        URL_Image = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblGames");
        }
    }
}
