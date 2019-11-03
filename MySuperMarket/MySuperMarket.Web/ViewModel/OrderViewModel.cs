using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySuperMarket.Web.ViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ShippingAddress { get; set; }
        public int OrderTotal { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer OrderCustomer { get; set; }
        public virtual ICollection<OrderItemBO> Items { get; set; }
    }
}
