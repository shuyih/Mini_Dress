using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity.Infrastructure;

namespace MiniDress.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MiniDressContext(
                serviceProvider.GetRequiredService<DbContextOptions<MiniDressContext>>()))
            {
                // Look for any movies.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                     new Product
                     {
                         Id = 1,
                         Name = "Product 1",
                         Description = "Romantic Comedy",
                         Price = 7.99M,
                         Image = "",
                         Discount = 3,
                         OrderItems = null                         
                     },

                     new Product
                     {
                         Id = 1,
                         Name = "Product 1",
                         Description = "Romantic Comedy",
                         Price = 7.99M,
                         Image = "",
                         Discount = 3,
                         OrderItems = null
                     },

                     new Product
                     {
                         Id = 1,
                         Name = "Product 1",
                         Description = "Romantic Comedy",
                         Price = 7.99M,
                         Image = "",
                         Discount = 3,
                         OrderItems = null
                     },

                   new Product
                   {
                       Id = 1,
                       Name = "Product 1",
                       Description = "Romantic Comedy",
                       Price = 7.99M,
                       Image = "",
                       Discount = 3,
                       OrderItems = null

                   }
                );
                context.SaveChanges();
            }
        }
    }

}
