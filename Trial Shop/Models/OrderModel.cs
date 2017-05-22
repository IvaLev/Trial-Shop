using System;
using System.Collections.Generic;

namespace Trial_Shop.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedOn { get; set; }

        public List<OrderProductModel> OrderProducts { get; set; }
    }
}
