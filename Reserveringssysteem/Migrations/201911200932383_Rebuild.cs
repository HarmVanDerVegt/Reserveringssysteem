namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rebuild : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Street = c.String(nullable: false),
                        HouseNumber = c.Int(nullable: false),
                        Suffix = c.String(),
                        ZIP = c.String(nullable: false),
                        City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        Organisation = c.String(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Team_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teams", t => t.Team_ID)
                .Index(t => t.Team_ID);
            
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BoatTypes",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Size = c.Int(nullable: false),
                        HasCoxswain = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Certificates", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Boats",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BoatStatus = c.Int(nullable: false),
                        BoatType_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BoatTypes", t => t.BoatType_ID, cascadeDelete: true)
                .Index(t => t.BoatType_ID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Boat_ID = c.Int(nullable: false),
                        Team_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Boats", t => t.Boat_ID, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.Team_ID, cascadeDelete: true)
                .Index(t => t.Boat_ID)
                .Index(t => t.Team_ID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        User_ID = c.Int(),
                        Coxswain_ID = c.Int(),
                        Match_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .ForeignKey("dbo.Users", t => t.Coxswain_ID)
                .ForeignKey("dbo.Matches", t => t.Match_ID)
                .Index(t => t.User_ID)
                .Index(t => t.Coxswain_ID)
                .Index(t => t.Match_ID);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Distance = c.Int(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Type_ID = c.Int(nullable: false),
                        Team_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BoatTypes", t => t.Type_ID, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.Team_ID)
                .Index(t => t.Type_ID)
                .Index(t => t.Team_ID);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Time = c.Time(nullable: false, precision: 7),
                        Position = c.Int(nullable: false),
                        Match_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Matches", t => t.Match_ID, cascadeDelete: true)
                .Index(t => t.Match_ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserCertificates",
                c => new
                    {
                        User_ID = c.Int(nullable: false),
                        Certificate_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Certificate_ID })
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .ForeignKey("dbo.Certificates", t => t.Certificate_ID, cascadeDelete: true)
                .Index(t => t.User_ID)
                .Index(t => t.Certificate_ID);
            
            CreateTable(
                "dbo.RoleMembers",
                c => new
                    {
                        Role_ID = c.Int(nullable: false),
                        Member_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_ID, t.Member_ID })
                .ForeignKey("dbo.Roles", t => t.Role_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Member_ID, cascadeDelete: true)
                .Index(t => t.Role_ID)
                .Index(t => t.Member_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "ID", "dbo.Users");
            DropForeignKey("dbo.RoleMembers", "Member_ID", "dbo.Users");
            DropForeignKey("dbo.RoleMembers", "Role_ID", "dbo.Roles");
            DropForeignKey("dbo.BoatTypes", "ID", "dbo.Certificates");
            DropForeignKey("dbo.Reservations", "Team_ID", "dbo.Teams");
            DropForeignKey("dbo.Users", "Team_ID", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team_ID", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Type_ID", "dbo.BoatTypes");
            DropForeignKey("dbo.Results", "Match_ID", "dbo.Matches");
            DropForeignKey("dbo.Teams", "Match_ID", "dbo.Matches");
            DropForeignKey("dbo.Teams", "Coxswain_ID", "dbo.Users");
            DropForeignKey("dbo.Teams", "User_ID", "dbo.Users");
            DropForeignKey("dbo.UserCertificates", "Certificate_ID", "dbo.Certificates");
            DropForeignKey("dbo.UserCertificates", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Reservations", "Boat_ID", "dbo.Boats");
            DropForeignKey("dbo.Boats", "BoatType_ID", "dbo.BoatTypes");
            DropIndex("dbo.RoleMembers", new[] { "Member_ID" });
            DropIndex("dbo.RoleMembers", new[] { "Role_ID" });
            DropIndex("dbo.UserCertificates", new[] { "Certificate_ID" });
            DropIndex("dbo.UserCertificates", new[] { "User_ID" });
            DropIndex("dbo.Results", new[] { "Match_ID" });
            DropIndex("dbo.Matches", new[] { "Team_ID" });
            DropIndex("dbo.Matches", new[] { "Type_ID" });
            DropIndex("dbo.Teams", new[] { "Match_ID" });
            DropIndex("dbo.Teams", new[] { "Coxswain_ID" });
            DropIndex("dbo.Teams", new[] { "User_ID" });
            DropIndex("dbo.Reservations", new[] { "Team_ID" });
            DropIndex("dbo.Reservations", new[] { "Boat_ID" });
            DropIndex("dbo.Boats", new[] { "BoatType_ID" });
            DropIndex("dbo.BoatTypes", new[] { "ID" });
            DropIndex("dbo.Users", new[] { "Team_ID" });
            DropIndex("dbo.Addresses", new[] { "ID" });
            DropTable("dbo.RoleMembers");
            DropTable("dbo.UserCertificates");
            DropTable("dbo.Roles");
            DropTable("dbo.Results");
            DropTable("dbo.Matches");
            DropTable("dbo.Teams");
            DropTable("dbo.Reservations");
            DropTable("dbo.Boats");
            DropTable("dbo.BoatTypes");
            DropTable("dbo.Certificates");
            DropTable("dbo.Users");
            DropTable("dbo.Addresses");
        }
    }
}
