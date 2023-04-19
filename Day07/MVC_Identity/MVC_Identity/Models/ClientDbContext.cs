using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web;



namespace MVC_Identity.Models
{
    public class ClientDbContext:DbContext
    {
        public ClientDbContext():base("Con")
        {

        }
       
        public DbSet<Client> Clients { get; set; }  
    }
}