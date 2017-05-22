using System.Collections.Generic;
using System.Linq;
using Trial_Shop.Interfaces;
using Trial_Shop.Models;
using Trial_Shop.Repository.DataBase;

namespace Trial_Shop.Repository
{
    public class OrderProductRepository:BaseRepository, IOrderProductRepository
    {
        public OrderProductRepository(ShopModel context) : base(context)
        {
        }

        public OrderProductModel Convert(OrderProduct orderProduct)
        {
            if (orderProduct == null)
            {
                return null;
            }

            return new OrderProductModel()
            {
                OrderProductId = orderProduct.OrderProductId,
                OrderId = orderProduct.OrderId,
                ProductId = orderProduct.ProductId
            };
        }

        public List<OrderProductModel> GetOrderProducts(int? orderId = null)
        {
            if (orderId.HasValue)
            {
                return Context.OrderProducts.Where(ordpr => ordpr.OrderId == orderId.Value).Select(Convert).ToList();
            }
            else
            {
                return Context.OrderProducts.Select(Convert).ToList();
            }
        }
    }
}
