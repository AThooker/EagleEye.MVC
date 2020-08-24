namespace EagleEye.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncidentTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Incident", "VictimId", "dbo.Victim");
            DropIndex("dbo.Incident", new[] { "VictimId" });
            AddColumn("dbo.Incident", "PerpID", c => c.Int(nullable: false));
            CreateIndex("dbo.Incident", "VictimID");
            CreateIndex("dbo.Incident", "PerpID");
            AddForeignKey("dbo.Incident", "PerpID", "dbo.Victim", "VictimID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Incident", "PerpID", "dbo.Victim");
            DropIndex("dbo.Incident", new[] { "PerpID" });
            DropIndex("dbo.Incident", new[] { "VictimID" });
            DropColumn("dbo.Incident", "PerpID");
            CreateIndex("dbo.Incident", "VictimId");
            AddForeignKey("dbo.Incident", "VictimId", "dbo.Victim", "VictimID", cascadeDelete: true);
        }
    }
}
