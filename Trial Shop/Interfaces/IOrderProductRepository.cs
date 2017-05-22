using System.Collections.Generic;
using Trial_Shop.Models;

namespace Trial_Shop.Interfaces
{
    public interface IOrderProductRepository
    {
        List<OrderProductModel> GetOrderProducts(int? orderId = null);
    }
}
