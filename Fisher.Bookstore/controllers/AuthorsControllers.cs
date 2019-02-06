using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Hello WorldAu");
            return View();
        }
        public IActionResult Featured()
        {
            //return Content("Hello WorldAuF");
            return View();
        }
        
    }
}