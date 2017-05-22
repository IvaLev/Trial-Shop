using System.Collections.Generic;
using Trial_Shop.Models;

namespace Trial_Shop.Interfaces
{
    public interface IProductRepository
    {
        List<ProductModel> GetAllProducts();
        ProductModel GetProduct(int id);
    }
}
