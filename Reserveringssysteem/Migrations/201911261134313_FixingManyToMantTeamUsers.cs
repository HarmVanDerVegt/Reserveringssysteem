namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingManyToMantTeamUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Results", "MatchTeam_ID", c => c.Int());
            CreateIndex("dbo.Results", "MatchTeam_ID");
            AddForeignKey("dbo.Results", "MatchTeam_ID", "dbo.Teams", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "MatchTeam_ID", "dbo.Teams");
            DropIndex("dbo.Results", new[] { "MatchTeam_ID" });
            DropColumn("dbo.Results", "MatchTeam_ID");
        }
    }
}
