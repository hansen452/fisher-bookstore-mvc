using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Hello WorldAI");
            return View();
        }
        public IActionResult History()
        {
            //return Content("Hello WorldAH");
            return View();
        }
        public IActionResult Location()
        {
            //return Content("Hello WorldAL");
            return View();
        }
    }
}