using System.Collections.Generic;
using System.Linq;

namespace GroShopify.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ProductDbContext context;

        public EFProductRepository(ProductDbContext ctx) 
        {
            context = ctx;
        } 

        public IQueryable<Product> Products => context.Products;
    }
}