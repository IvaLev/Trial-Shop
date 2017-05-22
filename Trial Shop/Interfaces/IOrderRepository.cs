using System.Collections.Generic;
using Trial_Shop.Models;

namespace Trial_Shop.Interfaces
{
    public interface IOrderRepository
    {
        List<OrderModel> GetAllOrders();
        List<OrderModel> GetUserOrders(int userId);
        void CreateOrder(OrderModel order);
    }
}
