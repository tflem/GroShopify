using System.Linq

namespace GroShopify.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }         
    }
}