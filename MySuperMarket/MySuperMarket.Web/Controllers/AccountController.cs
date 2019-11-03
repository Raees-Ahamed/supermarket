using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MySuperMarket.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult NewOrder()
        {

            return View();
        }
    }
}