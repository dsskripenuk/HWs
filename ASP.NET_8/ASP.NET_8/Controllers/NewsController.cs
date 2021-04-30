using ASP.NET_8.Entity;
using ASP.NET_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_8.Controllers
{
    public class NewsController : Controller
    {
        private ApplicationDbContext _context;

        public NewsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [Authorize]
        public ActionResult Create(CreateNewsViewModel model)
        {
            _context.News.Add(new News
            {
                Description = model.Description,
                Image_Url = model.Image_Url,
                ReleaseDate = model.ReleaseDate,
                Title = model.Ttitle
            });

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");


        }
    }
}