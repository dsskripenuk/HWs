namespace ASP.NET_Practice_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCharacters",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        BirthDate = c.String(nullable: false),
                        Rating = c.Int(nullable: false),
                        Gender = c.String(nullable: false),
                        URL_Image = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblCharacters");
        }
    }
}
