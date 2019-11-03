using MySuperMarket.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity;

namespace MySuperMarket.DAL.DataContext
{
    public class ShopCartDbContext : IdentityDbContext<Customer>
    {
        public ShopCartDbContext(DbContextOptions<ShopCartDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                        new Product
                        {
                            Id=1,
                            Name = "Chocolate",
                            CurrentPrice = 160,
                            Description = "Daily Milk",
                            StockAvailable = 60
                        },
                     new Product
                     {
                         Id = 2,
                         Name = "Toffee",
                         CurrentPrice = 5,
                         Description = "My Lady",
                         StockAvailable = 70
                     }, new Product
                     {
                         Id = 3,
                         Name = "Baby Soap",
                         CurrentPrice = 50,
                         Description = "Soap",
                         StockAvailable = 90
                     }
        );
            modelBuilder.Entity<Customer>().HasData(
                                 new Customer()
                                 {
                                     FirstName = "Umair",
                                     LastName = "Anhar",
                                     PhoneNumber = "0773060490",
                                     Address = "Colombo",
                                     Email = "Umair@gmail.com",
                                     PasswordHash="123"

                                 }, new Customer()
                                 {
                                     FirstName = "Anhar",
                                     LastName = "Paavada",
                                     PhoneNumber = "0773060400",
                                     Address = "Panadura",
                                     Email = "Anhar@gmail.com",
                                     PasswordHash = "1243"
                                 },
                new Customer()
                {
                    FirstName = "Ajmal",
                    LastName = "Ponsamy",
                    PhoneNumber = "0773060430",
                    Address = "Negambo",
                    Email = "Ajmal@gmail.com",
                    PasswordHash = "1243s"
                }
                );
            modelBuilder.Ignore<IdentityUserLogin<string>>();
        }
    }
}