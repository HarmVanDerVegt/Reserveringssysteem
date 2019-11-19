namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedBoatAttributes : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Boats", name: "Type_ID", newName: "BoatType_ID");
            RenameIndex(table: "dbo.Boats", name: "IX_Type_ID", newName: "IX_BoatType_ID");
            AddColumn("dbo.Boats", "BoatStatus", c => c.Int(nullable: false));
            DropColumn("dbo.Boats", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Boats", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Boats", "BoatStatus");
            RenameIndex(table: "dbo.Boats", name: "IX_BoatType_ID", newName: "IX_Type_ID");
            RenameColumn(table: "dbo.Boats", name: "BoatType_ID", newName: "Type_ID");
        }
    }
}
