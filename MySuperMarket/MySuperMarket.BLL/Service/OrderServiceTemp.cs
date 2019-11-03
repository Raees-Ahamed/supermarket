using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.BLL.ServiceInterface;
using MySuperMarket.DAL.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperMarket.BLL.Service
{
    public class OrderServiceTemp : IOrderService
    {
        private readonly ShopCartDbContext db;

        public OrderServiceTemp(ShopCartDbContext db)
        {
            this.db = db;
        }

        public int Add(OrderBO model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderBO> DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public OrderBO GetOrderByID(int id, bool withoutDeletedOrderItems)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderBO> GetRecentOrders()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(OrderBO model)
        {
            throw new NotImplementedException();
        }
    }
}
