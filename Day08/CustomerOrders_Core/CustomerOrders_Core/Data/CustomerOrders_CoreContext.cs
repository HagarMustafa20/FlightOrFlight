using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerOrders_Core.Model;

namespace CustomerOrders_Core.Data
{
    public class CustomerOrders_CoreContext : DbContext
    {
        public CustomerOrders_CoreContext (DbContextOptions<CustomerOrders_CoreContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerOrders_Core.Model.Course> Course { get; set; }

        public DbSet<CustomerOrders_Core.Model.Student> Student { get; set; }
    }
}
