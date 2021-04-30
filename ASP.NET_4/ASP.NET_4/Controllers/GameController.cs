using ASP.NET_4.Entity;
using ASP.NET_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_4.Controllers
{
    public class GameController : Controller
    {
        private EFContext _context;
        public GameController()
        {
            _context = new EFContext();
        }

        public ActionResult Index()
        {
            var data = _context.Games.Select(t => new GameViewModel
            {
                Id = t.Id,
                Name = t.Name,
                Description = t.Description,
                Developer = t.Developer,
                Price = t.Price,
                URL_Image = t.URL_Image

            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateGameViewModel model)
        {
            _context.Games.Add(new Games
            {
                Name = model.Name,
                Description = model.Description,
                Developer = model.Developer,
                Price = model.Price,
                URL_Image = model.URL_Image
            });

            _context.SaveChanges();

            return RedirectToAction("Index", "Game");
        }
    }
}