using System.Collections.Generic;
using Trial_Shop.Models;

namespace Trial_Shop.ViewModels
{
    public class ProductsViewModel
    {
        public ProductsViewModel()
        {
            Products = new List<ProductModel>();
        }
        public List<ProductModel> Products { get; set; }
    }
}
