namespace LibrarySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderModelCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        BookCount = c.Int(nullable: false),
                        TakenAt = c.DateTime(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                        FinePrice = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "BookId", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "BookId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.Orders");
        }
    }
}
