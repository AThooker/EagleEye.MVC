namespace EagleEye.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Incident", "TimeOfIncident", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.Incident", "CreatedUtc", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Incident", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Incident", "TimeOfIncident", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
