namespace Clientes2S_Backend.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Clientes2S_Backend.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Clientes2S_Backend.Models.Clientes2S_BackendContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Clientes2S_Backend.Models.Clientes2S_BackendContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Clients.AddOrUpdate(c => c.Id,
                new Client { Id = 1, Association = "Directo", Name = "2Secure", State = "Normal", LastContact = DateTime.Now, Comments = "", Pendings = "" });
        }
    }
}
