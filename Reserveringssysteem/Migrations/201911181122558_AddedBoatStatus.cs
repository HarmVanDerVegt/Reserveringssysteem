namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBoatStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Boats", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Boats", "Status");
        }
    }
}
