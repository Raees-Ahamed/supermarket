using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.BLL.ServiceInterface;
using MySuperMarket.DAL.DataContext;
using MySuperMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MySuperMarket.BLL.Service
{
    public class ProductServiceTemp : IProductService
    {
        private readonly ShopCartDbContext db;

        public ProductServiceTemp(ShopCartDbContext db)
        {
            this.db = db;
        }

        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var query = from r in db.Products
                        orderby r.Id
                        select r;

            return query;
        }

        public IEnumerable<Product> GetProductAutoCompleteList(string searchKey)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductQuantity(int productId, int productQuantity, bool isDeleted)
        {
            throw new NotImplementedException();
        }

    }
}
