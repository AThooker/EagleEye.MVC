namespace EagleEye.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Incident",
                c => new
                    {
                        IncidentID = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        TimeOfIncident = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        Address = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.IncidentID);
            
            CreateTable(
                "dbo.Perp",
                c => new
                    {
                        PerpID = c.Int(nullable: false, identity: true),
                        Height = c.String(),
                        Build = c.String(),
                        Age = c.Int(nullable: false),
                        Transportation = c.String(),
                        IncidentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PerpID)
                .ForeignKey("dbo.Incident", t => t.IncidentId, cascadeDelete: true)
                .Index(t => t.IncidentId);
            
            CreateTable(
                "dbo.Victim",
                c => new
                    {
                        VictimID = c.Int(nullable: false, identity: true),
                        Height = c.String(),
                        Build = c.String(),
                        Age = c.Int(nullable: false),
                        IncidentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VictimID)
                .ForeignKey("dbo.Incident", t => t.IncidentId, cascadeDelete: true)
                .Index(t => t.IncidentId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.Victim", "IncidentId", "dbo.Incident");
            DropForeignKey("dbo.Perp", "IncidentId", "dbo.Incident");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.Victim", new[] { "IncidentId" });
            DropIndex("dbo.Perp", new[] { "IncidentId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Victim");
            DropTable("dbo.Perp");
            DropTable("dbo.Incident");
        }
    }
}
