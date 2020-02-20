namespace LibrarySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinePriceNullableSetted : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "FinePrice", c => c.Decimal(storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "FinePrice", c => c.Decimal(nullable: false, storeType: "money"));
        }
    }
}
