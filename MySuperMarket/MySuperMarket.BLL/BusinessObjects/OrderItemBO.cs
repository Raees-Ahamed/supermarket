using MySuperMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperMarket.BLL.BusinessObjects
{
    public class OrderItemBO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public bool IsDeleted { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
