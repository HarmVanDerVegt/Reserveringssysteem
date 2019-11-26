namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeRoleTypesUnique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Roles", "Type", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Roles", new[] { "Type" });
        }
    }
}
