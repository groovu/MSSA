using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod5Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Price = 4;
            ViewBag.names = new List<string>() { "deepali", "name1", "name2" };
            return View();
        }
    }
}
