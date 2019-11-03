using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MySuperMarket.DAL.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(250)]
        public string ShippingAddress { get; set; }
        public string CustomerId { get; set; }
        public int OrderTotal { get; set; }
        public bool OrderIsDeleted { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer OrderCustomer { get; set; }
    }
}
