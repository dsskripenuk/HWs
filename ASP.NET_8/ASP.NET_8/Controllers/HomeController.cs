using ASP.NET_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_8.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var data = _context.News.Select(t => new NewsViewModel
            {
                Description = t.Description,
                Image_Url = t.Image_Url,
                ReleaseDate = t.ReleaseDate,
                Title = t.Title
            }).ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}