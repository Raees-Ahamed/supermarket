using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySuperMarket.BLL.BusinessObjects;
using MySuperMarket.BLL.Service;
using MySuperMarket.BLL.ServiceInterface;
using MySuperMarket.DAL.DataContext;
using MySuperMarket.DAL.Entity;
using MySuperMarket.DAL.Implementation;
using MySuperMarket.DAL.Interface;

namespace MySuperMarket.Web.Controllers
{
    public class ProductController : Controller
    {
        IProductService productServiceTemp;

        public IEnumerable<Product> Products { get; set; }

        public ProductController(IProductService productServiceTemp)
        {
            this.productServiceTemp = productServiceTemp;
        }

        public ActionResult Index()
        {
            var model = productServiceTemp.GetAllProducts();

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product) {

            if(String.IsNullOrEmpty(product.Name))
            {
                ModelState.AddModelError(nameof(product.Name), "The name is required");
            }

            if(ModelState.IsValid)
            {
                productServiceTemp.AddProduct(product);
                return RedirectToAction("Index");
            } else
            {
                return View();
            }
        }

    }
}