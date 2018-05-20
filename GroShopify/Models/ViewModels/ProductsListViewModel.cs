using System.Collections.Generic;
using GroShopify.Models;

namespace GroShopify.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }        
    }
}