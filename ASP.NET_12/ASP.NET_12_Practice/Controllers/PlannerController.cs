using ASP.NET_12_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_12_Practice.Controllers
{
    [Authorize]
    public class PlannerController : Controller
    {
        private readonly ApplicationDbContext _context;

        // GET: Planner
        [HttpGet]
        public ActionResult Index()
        {

            List<ListEventsViewModel> data = _context.Events.Select(t => new ListEventsViewModel()
            {
                Id = t.Id,
                Event = t.Event,
                Time = t.Time,
                Date = t.Date
            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddListEventsViewModel t)
        {
            _context.Events.Add(new Entity.ListEvents
            {
                Event = t.Event,
                Time = t.Time,
                Date = t.Date
            });

            return RedirectToAction("Index", "Events");
        }

    }
}