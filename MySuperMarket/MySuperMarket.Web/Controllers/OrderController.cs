using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MySuperMarket.BLL.ServiceInterface;
using MySuperMarket.Web.ViewModel;

namespace MySuperMarket.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        public readonly IProductService productService;
        public SelectList AllProducts;

        public int SelectedProductId;

        public OrderController(IOrderService orderService,IProductService productService)
        {
            this.orderService = orderService;
            this.productService = productService;
        }

        public ActionResult NewOrder()
        {
            var productList = productService.GetAllProducts();
            AllProducts = new SelectList(productList, "Id", "Name");

            return View();
        }
    }
}