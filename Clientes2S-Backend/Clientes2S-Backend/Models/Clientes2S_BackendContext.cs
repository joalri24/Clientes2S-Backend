using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Clientes2S_Backend.Models
{
    public class Clientes2S_BackendContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Clientes2S_BackendContext() : base("name=Clientes2S_BackendContext")
        {
        }

        public System.Data.Entity.DbSet<Clientes2S_Backend.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<Clientes2S_Backend.Models.Job> Jobs { get; set; }

        public System.Data.Entity.DbSet<Clientes2S_Backend.Models.Contact> Contacts { get; set; }
    }
}
