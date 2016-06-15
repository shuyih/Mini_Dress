using Microsoft.Data.Entity;
using MiniDress;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MiniDress.Models
{
    public class MiniDressContext : DbContext
    {
        public MiniDressContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connStr = Startup.Configuration["Data:DefaultConnection:ConnectionString"];            
            builder.UseSqlServer(connStr);
            base.OnConfiguring(builder);
        }
    }
}
