using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clientes2S_Backend.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Association { get; set; }

        public string Comments { get; set; }

        public string Pendings { get; set; }

        public DateTime LastContact { get; set; }

        public string State { get; set; }

        // Foreign Key
        public int MainContactId { get; set; }

        // Navigation properties
        public Contact MainContact { get; set; }
 
        public ICollection<Job> Jobs { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }
}