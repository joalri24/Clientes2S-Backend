namespace Clientes2S_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollow : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Follow", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Follow");
        }
    }
}
