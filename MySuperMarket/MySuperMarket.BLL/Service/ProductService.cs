using AutoMapper;
using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.BLL.ServiceInterface;
using MySuperMarket.DAL.Entity;
using MySuperMarket.DAL.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySuperMarket.BLL.Service
{
    public class ProductService 
    {
        //private IUnitOfWork unitOfWork;
        //public readonly IMapper _mapper;
        //public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        //{
        //    this.unitOfWork = unitOfWork;
        //    _mapper = mapper;
        //}

        //public IEnumerable<ProductBO> GetProductAutoCompleteList(string searchKey)
        //{
        //    var productList = (unitOfWork.ProductRepository.Get()
        //          .Where(r => r.Name.StartsWith(searchKey, StringComparison.InvariantCultureIgnoreCase))
        //             .Select(r => new ProductBO
        //             {
        //                 Id = r.Id,
        //                 Name = r.Name
        //             }));
        //    if (productList.Count() == 0)
        //    {
        //        productList = productList.Concat(new ProductBO[] { new ProductBO() { Id = -1, Name = "There Is No Such A Product In Database" } });
        //        return productList;
        //    }
        //    else
        //    {
        //        return productList;
        //    }
        //}

        //public ProductBO GetProductByID(int id)
        //{
        //    var product = unitOfWork.ProductRepository.GetByID(id);
        //    if (product == null)
        //    {
        //        throw new Exception();
        //    }
        //    return _mapper.Map<ProductBO>(product);
        //}

        //public void UpdateProductQuantity(int productId, int productQuantity, bool isDeleted)
        //{
        //    var editModel = GetProductByID(productId);
        //    if (editModel == null)
        //    {
        //        throw new Exception();
        //    }
        //    if (isDeleted)
        //    {
        //        editModel.StockAvailable = editModel.StockAvailable + productQuantity;
        //    }
        //    else
        //    {
        //        if (editModel.StockAvailable >= productQuantity)
        //        {
        //            editModel.StockAvailable = editModel.StockAvailable - productQuantity;
        //        }
        //        else
        //        {
        //            { throw new Exception("There is only " + editModel.StockAvailable + " " + editModel.Name + " available in the stock"); }
        //        }
        //    }
        //    try
        //    {
        //        var mapper = _mapper.Map<Product>(editModel);
        //        unitOfWork.ProductRepository.Update(mapper);
        //        unitOfWork.Save();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("A Database Error Occured While Updateing The Order", ex);
        //    }
        //}

        //public IEnumerable<ProductBO> GetAllProducts()
        //{
        //    var productList = (unitOfWork.ProductRepository.Get()
        //             .Select(r => new ProductBO
        //             {
        //                 Id = r.Id,
        //                 Name = r.Name
        //             }));

        //    if (productList.Count() == 0)
        //    {
        //        productList = productList.Concat(new ProductBO[] { new ProductBO() { Id = -1, Name = "Sorry no product found!, Would you like to add?" } });
        //        return productList;
        //    }
        //    else
        //    {
        //        return productList;
        //    }
        //}
    }
}
