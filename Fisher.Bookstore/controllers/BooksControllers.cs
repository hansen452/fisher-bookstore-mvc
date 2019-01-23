using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello WorldBI");
        }
        public IActionResult New()
        {
            return Content("Hello WorldBN");
        }
        public IActionResult Best()
        {
            return Content("Hello WorldBB");
        }
    }
}