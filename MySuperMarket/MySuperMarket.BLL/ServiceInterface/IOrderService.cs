using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperMarket.BLL.ServiceInterface
{
    public interface IOrderService
    {
        int Add(OrderBO model);
        OrderBO GetOrderByID(int id, bool withoutDeletedOrderItems);
        IEnumerable<OrderBO> GetRecentOrders();
        IEnumerable<OrderBO> DeleteOrder(int id);
        void UpdateOrder(OrderBO model);
    }
}
