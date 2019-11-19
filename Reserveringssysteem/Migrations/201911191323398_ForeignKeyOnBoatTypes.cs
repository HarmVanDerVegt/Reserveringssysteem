namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyOnBoatTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserCertificates", "Certificate_ID", "dbo.Certificates");
            DropForeignKey("dbo.BoatTypes", "ID", "dbo.Certificates");
            DropForeignKey("dbo.Boats", "BoatType_ID", "dbo.BoatTypes");
            DropForeignKey("dbo.Matches", "Type_ID", "dbo.BoatTypes");
            DropIndex("dbo.BoatTypes", new[] { "ID" });
            DropPrimaryKey("dbo.Certificates");
            DropPrimaryKey("dbo.BoatTypes");
            AlterColumn("dbo.Certificates", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.BoatTypes", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Certificates", "ID");
            AddPrimaryKey("dbo.BoatTypes", "ID");
            CreateIndex("dbo.Certificates", "ID");
            AddForeignKey("dbo.UserCertificates", "Certificate_ID", "dbo.Certificates", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Boats", "BoatType_ID", "dbo.BoatTypes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Matches", "Type_ID", "dbo.BoatTypes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Certificates", "ID", "dbo.BoatTypes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Certificates", "ID", "dbo.BoatTypes");
            DropForeignKey("dbo.Matches", "Type_ID", "dbo.BoatTypes");
            DropForeignKey("dbo.Boats", "BoatType_ID", "dbo.BoatTypes");
            DropForeignKey("dbo.UserCertificates", "Certificate_ID", "dbo.Certificates");
            DropIndex("dbo.Certificates", new[] { "ID" });
            DropPrimaryKey("dbo.BoatTypes");
            DropPrimaryKey("dbo.Certificates");
            AlterColumn("dbo.BoatTypes", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Certificates", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.BoatTypes", "ID");
            AddPrimaryKey("dbo.Certificates", "ID");
            CreateIndex("dbo.BoatTypes", "ID");
            AddForeignKey("dbo.Matches", "Type_ID", "dbo.BoatTypes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Boats", "BoatType_ID", "dbo.BoatTypes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.BoatTypes", "ID", "dbo.Certificates", "ID");
            AddForeignKey("dbo.UserCertificates", "Certificate_ID", "dbo.Certificates", "ID", cascadeDelete: true);
        }
    }
}
