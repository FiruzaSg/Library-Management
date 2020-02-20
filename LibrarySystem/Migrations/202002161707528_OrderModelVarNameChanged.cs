namespace LibrarySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderModelVarNameChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "IsOpen", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "IsDone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "IsDone", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "IsOpen");
        }
    }
}
