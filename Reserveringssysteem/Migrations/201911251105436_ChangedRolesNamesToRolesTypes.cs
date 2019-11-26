namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedRolesNamesToRolesTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Roles", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Roles", "Type");
        }
    }
}
