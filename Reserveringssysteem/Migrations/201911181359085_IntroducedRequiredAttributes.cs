namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntroducedRequiredAttributes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Boats", "Type_ID", "dbo.BoatTypes");
            DropForeignKey("dbo.Matches", "Type_ID", "dbo.BoatTypes");
            DropForeignKey("dbo.Reservations", "Boat_ID", "dbo.Boats");
            DropForeignKey("dbo.Reservations", "Team_ID", "dbo.Teams");
            DropForeignKey("dbo.Results", "Match_ID", "dbo.Matches");
            DropIndex("dbo.Boats", new[] { "Type_ID" });
            DropIndex("dbo.Reservations", new[] { "Boat_ID" });
            DropIndex("dbo.Reservations", new[] { "Team_ID" });
            DropIndex("dbo.Matches", new[] { "Type_ID" });
            DropIndex("dbo.Results", new[] { "Match_ID" });
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Organisation", c => c.String(nullable: false));
            AlterColumn("dbo.Certificates", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.BoatTypes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Boats", "Type_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Reservations", "Boat_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Reservations", "Team_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Matches", "Type_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Results", "Match_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Roles", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Boats", "Type_ID");
            CreateIndex("dbo.Reservations", "Boat_ID");
            CreateIndex("dbo.Reservations", "Team_ID");
            CreateIndex("dbo.Matches", "Type_ID");
            CreateIndex("dbo.Results", "Match_ID");
            AddForeignKey("dbo.Boats", "Type_ID", "dbo.BoatTypes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Matches", "Type_ID", "dbo.BoatTypes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Reservations", "Boat_ID", "dbo.Boats", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Reservations", "Team_ID", "dbo.Teams", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Results", "Match_ID", "dbo.Matches", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "Match_ID", "dbo.Matches");
            DropForeignKey("dbo.Reservations", "Team_ID", "dbo.Teams");
            DropForeignKey("dbo.Reservations", "Boat_ID", "dbo.Boats");
            DropForeignKey("dbo.Matches", "Type_ID", "dbo.BoatTypes");
            DropForeignKey("dbo.Boats", "Type_ID", "dbo.BoatTypes");
            DropIndex("dbo.Results", new[] { "Match_ID" });
            DropIndex("dbo.Matches", new[] { "Type_ID" });
            DropIndex("dbo.Reservations", new[] { "Team_ID" });
            DropIndex("dbo.Reservations", new[] { "Boat_ID" });
            DropIndex("dbo.Boats", new[] { "Type_ID" });
            AlterColumn("dbo.Roles", "Name", c => c.String());
            AlterColumn("dbo.Results", "Match_ID", c => c.Int());
            AlterColumn("dbo.Matches", "Type_ID", c => c.Int());
            AlterColumn("dbo.Reservations", "Team_ID", c => c.Int());
            AlterColumn("dbo.Reservations", "Boat_ID", c => c.Int());
            AlterColumn("dbo.Boats", "Type_ID", c => c.Int());
            AlterColumn("dbo.BoatTypes", "Name", c => c.String());
            AlterColumn("dbo.Certificates", "Name", c => c.String());
            AlterColumn("dbo.Users", "Organisation", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            CreateIndex("dbo.Results", "Match_ID");
            CreateIndex("dbo.Matches", "Type_ID");
            CreateIndex("dbo.Reservations", "Team_ID");
            CreateIndex("dbo.Reservations", "Boat_ID");
            CreateIndex("dbo.Boats", "Type_ID");
            AddForeignKey("dbo.Results", "Match_ID", "dbo.Matches", "ID");
            AddForeignKey("dbo.Reservations", "Team_ID", "dbo.Teams", "ID");
            AddForeignKey("dbo.Reservations", "Boat_ID", "dbo.Boats", "ID");
            AddForeignKey("dbo.Matches", "Type_ID", "dbo.BoatTypes", "ID");
            AddForeignKey("dbo.Boats", "Type_ID", "dbo.BoatTypes", "ID");
        }
    }
}
