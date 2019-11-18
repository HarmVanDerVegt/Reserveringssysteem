namespace Reserveringssysteem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressAttrRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "Street", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "ZIP", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "City", c => c.String());
            AlterColumn("dbo.Addresses", "ZIP", c => c.String());
            AlterColumn("dbo.Addresses", "Street", c => c.String());
        }
    }
}
