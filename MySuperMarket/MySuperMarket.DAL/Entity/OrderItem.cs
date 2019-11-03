using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MySuperMarket.DAL.Entity
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public bool IsDeleted { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}
