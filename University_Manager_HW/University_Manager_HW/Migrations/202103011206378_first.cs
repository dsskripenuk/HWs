namespace University_Manager_HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        EducationStartDate = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ImgUrl = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        RealeseDate = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.tblStudentGroup",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .ForeignKey("dbo.tblGroups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.tblTeacherAdditionalInfo",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Image = c.String(nullable: false),
                        Skills = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.tblUserAdditionalInfo",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Image = c.String(nullable: false),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .ForeignKey("dbo.tblGroups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.GroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblStudentGroup", "GroupId", "dbo.tblGroups");
            DropForeignKey("dbo.tblStudentGroup", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.tblUserAdditionalInfo", "GroupId", "dbo.tblGroups");
            DropForeignKey("dbo.tblUserAdditionalInfo", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.tblTeacherAdditionalInfo", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.tblUserAdditionalInfo", new[] { "GroupId" });
            DropIndex("dbo.tblUserAdditionalInfo", new[] { "Id" });
            DropIndex("dbo.tblTeacherAdditionalInfo", new[] { "Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.tblStudentGroup", new[] { "GroupId" });
            DropIndex("dbo.tblStudentGroup", new[] { "Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.tblUserAdditionalInfo");
            DropTable("dbo.tblTeacherAdditionalInfo");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.tblStudentGroup");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.tblNews");
            DropTable("dbo.tblGroups");
        }
    }
}
