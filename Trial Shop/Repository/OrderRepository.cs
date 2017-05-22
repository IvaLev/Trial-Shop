using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Trial_Shop.Interfaces;
using Trial_Shop.Models;
using Trial_Shop.Repository.DataBase;

namespace Trial_Shop.Repository
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(ShopModel context) : base(context)
        {
        }

        public OrderModel Convert(Order order)
        {
            if (order == null)
            {
                return null;
            }

            return new OrderModel()
            {
                OrderId = order.OrderId,
                UserId = order.UserId,
                Comment = order.Comment,
                CreatedOn = order.CreatedOn
            };
        }

        public List<OrderModel> GetAllOrders()
        {
            return Context.Orders.Select(Convert).ToList();
        }

        public List<OrderModel> GetUserOrders(int userId)
        {
            return Context.Orders.Where(o => o.UserId == userId).Select(Convert).ToList();
        }

        public void CreateOrder(OrderModel order)
        {
            if (order != null)
            {
                var newId = getNextOrderId();
                var newOrder = new Order()
                {
                    OrderId = newId,
                    UserId = 1, //default userId 1s
                    Comment = order.Comment, //need to write source of the request
                    CreatedOn = DateTime.Now
                };

                Context.Orders.AddOrUpdate(newOrder);
                Context.SaveChanges();

                foreach (var orderProduct in order.OrderProducts)
                {
                    CreateOrderProduct(orderProduct, newId);
                }
                //send email
            }
        }


        private void CreateOrderProduct(OrderProductModel orderProduct, int orderId)
        {
            if (orderProduct != null)
            {
                var newId = getNextOrderProductId();
                var newOrderProduct = new OrderProduct()
                {
                    OrderId = orderId,
                    OrderProductId = newId, //default userId 1s
                    ProductId = orderProduct.ProductId
                };

                Context.OrderProducts.AddOrUpdate(newOrderProduct);
                Context.SaveChanges();

            }
        }

        //need to add trigger OnCreate to autopopulate ids
        //temporary solving
        private int getNextOrderProductId()
        {
            return Context.OrderProducts.Count() + 1;
        }

        //need to add trigger OnCreate to autopopulate ids
        //temporary solving
        private int getNextOrderId()
        {
            return Context.Orders.Count() + 1;
        }
    }
}
