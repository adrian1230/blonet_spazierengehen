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
               new Blogs() { BlogId = 1, Author = "James",Title="abcde",Date="01-03-2019",Text="qwertyu"},
               new Blogs() { BlogId = 3, Author = "David",Title="fghij",Date="01-04-2019",Text="chgf"},
               new Blogs() { BlogId = 2, Author = "Smith",Title="klmno",Date="01-05-2019",Text="cuiafvjkoas"},
               new Blogs() { BlogId = 4, Author = "Sara", Title="pqrst",Date="01-06-2019",Text="ytrdfcvbs"},
               new Blogs() { BlogId = 5, Author = "Pam",  Title="uvwxy",Date="01-07-2019",Text="xcfgtoiujnbfas"}
            };
            return View(listBlogs);
        }
        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Text(int Id)
        {
            var details = new Blogs() {
                BlogId = Id,
                Author="James",
                Title="abcde",
                Date="01-03-2019",
                Text="qwertyu"   
            };
            return View(details);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
