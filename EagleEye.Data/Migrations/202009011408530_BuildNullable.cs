namespace EagleEye.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BuildNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Perp", "Build", c => c.Int());
            AlterColumn("dbo.Victim", "Build", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Victim", "Build", c => c.Int(nullable: false));
            AlterColumn("dbo.Perp", "Build", c => c.Int(nullable: false));
        }
    }
}
