using System.Collections.Generic;
using System.Linq;
using Trial_Shop.Interfaces;
using Trial_Shop.Repository.DataBase;

namespace Trial_Shop.Repository
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(ShopModel context) : base(context)
        {
        }

        public Models.ProductModel Convert(Product product)
        {
            if (product == null)
            {
                return null;
            }

            return new Models.ProductModel()
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price
            };
        }

        public List<Models.ProductModel> GetAllProducts()
        {
            return Context.Products.Select(Convert).ToList();
        }

        public Models.ProductModel GetProduct(int id)
        {
            return Convert(Context.Products.FirstOrDefault(pr => pr.ProductId == id));
        }
    }
}
