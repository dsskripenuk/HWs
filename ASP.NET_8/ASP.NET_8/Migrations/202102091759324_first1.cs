namespace ASP.NET_8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblNews", "Title", c => c.String(nullable: false));
            DropColumn("dbo.tblNews", "Ttitle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblNews", "Ttitle", c => c.String(nullable: false));
            DropColumn("dbo.tblNews", "Title");
        }
    }
}
