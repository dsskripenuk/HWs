using ASP.NET_HW_2.Entity;
using ASP.NET_HW_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_HW_2.Controllers
{
    public class CardController : Controller
    {
        private readonly EFContext _context;

        public CardController()
        {
            _context = new EFContext();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<CardViewModel> data = _context.Cards.Select(t => new CardViewModel()
            {
                Id = t.Id,
                Title = t.Title,
                Date = t.Date,
                FullDescription = t.FullDescription,
                ShortDescription = t.ShortDescription,
                Img = t.Img
            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddCardViewModel model)
        {
            _context.Cards.Add(new Card
            {
                Title = model.Title,
                Date = model.Date,
                FullDescription = model.FullDescription,
                ShortDescription = model.ShortDescription,
                Img = model.Img
            });
            _context.SaveChanges();

            return RedirectToAction("Index", "Card");
        }
    }
}