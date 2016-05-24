using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1;

namespace NewMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Class1 cls = new Class1();
            ViewBag.Square = cls.Square(42);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
