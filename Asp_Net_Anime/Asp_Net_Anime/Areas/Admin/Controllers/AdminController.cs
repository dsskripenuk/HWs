using Asp_Net_Anime.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp_Net_Anime.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;

        public AdminController()
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

        [HttpGet]
        public ActionResult AddEpisodes()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEpisodes(AddEpisodesViewModel model)
        {
            _context.Episodes.Add(new Entity.Episodes
            {
                Season = model.Season,
                Img_URL = model.Img_URL,
                Video_URL = model.Video_URL,
                AnimeId = model.AnimeId
            });

            _context.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }

        public ActionResult ScreenList()
        {
            var data = _context.Screenshots.Select(t => new ScreenshootViewModel
            {
                Id = t.Id,
                Image = t.Image,
                AnimeId = t.AnimeId
            });

            return View(data);
        }

        [HttpGet]
        public ActionResult AddScreenshot()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddScreenshot(AddScreenshootViewModel model)
        {
            _context.Screenshots.Add(new Entity.Screenshots
            {
                Image = model.Image,
                AnimeId = model.AnimeId
            });

            _context.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public ActionResult CreateAnime()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAnime(CreateAnimeViewModel model)
        {
            _context.animes.Add(new Entity.Anime 
            {
                Title = model.Title,
                Description = model.Description,
                CategoryId = model.CategoryId,
                Image = model.Image,
                ReleaseDate = model.ReleaseDate,
            });

            _context.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }

        public ActionResult CategoryList()
        {
            var data = _context.categories.Select(t => new CategoryViewModel
            {
                Id = t.Id,
                Name = t.Name
            });

            return View(data);
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(CreateCategoryViewModel model)
        {
            _context.categories.Add(new Entity.Category
            {
                Name = model.Name
            });

            _context.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }

        public ActionResult DeleteCategory(int id)
        {
            var deleteAnime = _context.categories.FirstOrDefault(t => t.Id == id);
            if (deleteAnime != null)
            {
                _context.categories.Remove(deleteAnime);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Admin");
        }

        public ActionResult Delete(int id)
        {
            var deleteAnime = _context.animes.FirstOrDefault(t => t.Id == id);
            if (deleteAnime != null)
            {
                _context.animes.Remove(deleteAnime);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Admin");
        }

    }
}
