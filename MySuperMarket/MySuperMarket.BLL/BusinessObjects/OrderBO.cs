using MySuperMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MySuperMarket.BLL.BusinessObjects
{
    public class OrderBO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ShippingAddress { get; set; }
        public string CustomerId { get; set; }
        public int OrderTotal { get; set; }
        public bool OrderIsDeleted { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer OrderCustomer { get; set; }
    }
}
