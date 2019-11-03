using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperMarket.BLL.ServiceInterface
{
    public interface IProductService
    {
        ProductBO GetProductByID(int id);
        IEnumerable<ProductBO> GetProductAutoCompleteList(string searchKey);
        void UpdateProductQuantity(int productId, int productQuantity, bool isDeleted);
    }
}
