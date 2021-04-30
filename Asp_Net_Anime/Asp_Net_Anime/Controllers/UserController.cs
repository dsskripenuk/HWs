using Asp_Net_Anime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp_Net_Anime.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext _context;

        public UserController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var data = _context.animes.Select(t => new AnimeViewModel
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                CategoryId = t.CategoryId,
                Image = t.Image,
                ReleaseDate = t.ReleaseDate
            });

            return View(data);
        }

        public ActionResult Details(int Id)
        {
            var data = _context.animes.Select(t => new ShowAnimeViewModel
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                Image = t.Image,
                ReleaseDate = t.ReleaseDate,
                CategoryName = _context.categories.FirstOrDefault(d => d.Id == t.CategoryId).Name
            }).FirstOrDefault(t => t.Id == Id);

            if (data != null)
                return View(data);
            else
                return RedirectToAction("Index", "User");
        }
    }
}