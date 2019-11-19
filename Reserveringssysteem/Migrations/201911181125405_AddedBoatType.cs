namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBoatType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BoatTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Size = c.Int(nullable: false),
                        HasCoxswain = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Boats", "Type_ID", c => c.Int());
            CreateIndex("dbo.Boats", "Type_ID");
            AddForeignKey("dbo.Boats", "Type_ID", "dbo.BoatTypes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Boats", "Type_ID", "dbo.BoatTypes");
            DropIndex("dbo.Boats", new[] { "Type_ID" });
            DropColumn("dbo.Boats", "Type_ID");
            DropTable("dbo.BoatTypes");
        }
    }
}
