namespace LibrarySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderAndDataannotationsUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "PublishedDate", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Books", "Price", c => c.Decimal(nullable: false, storeType: "money"));
            AddColumn("dbo.Books", "Count", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "IdentityCardNo", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Users", "Phone", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Users", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Status");
            DropColumn("dbo.Users", "Phone");
            DropColumn("dbo.Customers", "IdentityCardNo");
            DropColumn("dbo.Books", "Count");
            DropColumn("dbo.Books", "Price");
            DropColumn("dbo.Books", "PublishedDate");
        }
    }
}
