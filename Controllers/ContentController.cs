using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bloopers.Models;

namespace bloopers.Controllers
{
    public class ContentController : Controller
    {
        private readonly ILogger<ContentController> _logger;

        public ContentController(ILogger<ContentController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            List<Blogs> listBlogs = new List<Blogs>()
            {
               new Blogs() { BlogId = 1, Author = "James",Title="dfghj",Date="01-03-2019",Text="cuiahdias"},
               new Blogs() { BlogId = 3, Author = "David",Title="dfghj",Date="01-03-2019",Text="cuiahdias"},
               new Blogs() { BlogId = 2, Author = "Smith",Title="dfghj",Date="01-03-2019",Text="cuiahdias"},
               new Blogs() { BlogId = 4, Author = "Sara", Title="dfghj",Date="01-03-2019",Text="cuiahdias"},
               new Blogs() { BlogId = 5, Author = "Pam",  Title="dfghj",Date="01-03-2019",Text="cuiahdias"}
            };
            return View(listBlogs);
        }
        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Text(int Id)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
