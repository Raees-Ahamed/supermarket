using MySuperMarket.DAL.DataContext;
using MySuperMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperMarket.DAL.Implementation
{
    public interface IUnitOfWork
    {
        ShopCartDbContext DbContext { get; }

        GenericRepository<Customer> CustomerRepository { get; }
        GenericRepository<Order> OrderRepository { get; }
        GenericRepository<Product> ProductRepository { get; }
        GenericRepository<OrderItem> OrderItemRepository { get; }

        void Save();
    }
}
