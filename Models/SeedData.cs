using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace GroShopify.Models
{

    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ProductDbContext context = app.ApplicationServices
                .GetRequiredService<ProductDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Milk",
                        Quantity = 2
                    },
                    new Product
                    {
                        Name = "Eggs",
                        Quantity = 2
                    },
                    new Product
                    {
                        Name = "Water",
                        Quantity = 3
                    },
                    new Product
                    {
                        Name = "Pop",
                        Quantity = 3
                    },
                    new Product
                    {
                        Name = "Juice",
                        Quantity = 3
                    },
                    new Product
                    {
                        Name = "Deodorant",
                        Quantity = 3
                    }
                );
                context.SaveChanges();         
            } 
        }
    }
}