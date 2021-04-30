namespace ASP.NET_Practice_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblArts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        URL_Image = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblArts");
        }
    }
}
