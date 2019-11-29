namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenderToMatch : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "Gender", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Matches", "Gender");
        }
    }
}
