using ASPNET.Bootcamp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET.Bootcamp.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ASPNET.Bootcamp") { }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}
