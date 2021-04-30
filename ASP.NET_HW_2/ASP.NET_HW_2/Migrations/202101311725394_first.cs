namespace ASP.NET_HW_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCard",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Date = c.String(nullable: false),
                        FullDescription = c.String(nullable: false),
                        ShortDescription = c.String(nullable: false),
                        Img = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblCard");
        }
    }
}
