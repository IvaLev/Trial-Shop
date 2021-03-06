namespace Trial_Shop.Repository.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderProductId { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
