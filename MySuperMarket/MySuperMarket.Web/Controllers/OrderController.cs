using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySuperMarket.BLL.ServiceInterface;
using MySuperMarket.Web.ViewModel;

namespace MySuperMarket.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult NewOrder()
        {
            return View("NewOrder");
        }
    }
}