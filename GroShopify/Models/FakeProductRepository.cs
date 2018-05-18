using System.Collections.Generic;
using System.Linq;

namespace GroShopify.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Deodorant", Quantity = 2 },
            new Product { Name = "Boxer Shorts", Quantity = 4 },
            new Product { Name = "Razors", Quantity = 6 }
        }.AsQueryable<Product>();
    }
}