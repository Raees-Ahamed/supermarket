using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperMarket.BLL.ServiceInterface
{
    public interface IProductService
    {
        Product GetProductByID(int id);
        IEnumerable<Product> GetProductAutoCompleteList(string searchKey);
        void UpdateProductQuantity(int productId, int productQuantity, bool isDeleted);
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
    }
}
