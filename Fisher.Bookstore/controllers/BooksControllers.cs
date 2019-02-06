using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    [Route("books")]
    public class BooksController : Controller
    {
        [Route("")] //handles the route '/books'
        [Route("index")] //handles the route '/books/index'
        public IActionResult Index()
        {
            //return Content("Hello WorldBI");
            return View();
        }

        [Route("new")]
        public IActionResult New()
        {
            //return Content("Hello WorldBN");
            return View();
        }

        [Route("best-sellers")]
        public IActionResult Best()
        {
            //return Content("Hello WorldBB");
            return View();
        }
    }
}