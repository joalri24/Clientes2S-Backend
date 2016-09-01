namespace Clientes2S_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Association = c.String(nullable: false),
                        Comments = c.String(),
                        Pendings = c.String(),
                        LastContact = c.DateTime(nullable: false),
                        State = c.String(),
                        MainContactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        JobTitle = c.String(),
                        Telephone = c.String(),
                        Mail = c.String(),
                        LastContact = c.DateTime(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        State = c.String(),
                        Date = c.DateTime(nullable: false),
                        ContactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Contacts", "ClientId", "dbo.Clients");
            DropIndex("dbo.Jobs", new[] { "ClientId" });
            DropIndex("dbo.Contacts", new[] { "ClientId" });
            DropTable("dbo.Jobs");
            DropTable("dbo.Contacts");
            DropTable("dbo.Clients");
        }
    }
}
