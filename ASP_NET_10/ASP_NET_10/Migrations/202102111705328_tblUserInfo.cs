namespace ASP_NET_10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblUserInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblUserAdditionalInfo",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUserAdditionalInfo", "ID", "dbo.AspNetUsers");
            DropIndex("dbo.tblUserAdditionalInfo", new[] { "ID" });
            DropTable("dbo.tblUserAdditionalInfo");
        }
    }
}
