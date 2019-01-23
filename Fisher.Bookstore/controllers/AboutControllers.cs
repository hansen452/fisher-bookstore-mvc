using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello WorldAI");
        }
        public IActionResult History()
        {
            return Content("Hello WorldAH");
        }
        public IActionResult Location()
        {
            return Content("Hello WorldAL");
        }
    }
}