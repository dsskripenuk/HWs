using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouTube.Areas.Admin.Models;
using YouTube.Models;

namespace YouTube.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _context;

        public ActionResult Index()
        {
            List<CategoryViewModel> data = _context.Categories.Select(t => new CategoryViewModel()
            {
                Id = t.Id,
                Name = t.Name
            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddCategoryViewModel t)
        {
            _context.Categories.Add(new Entity.Category
            {
                Name = t.Name
            });

            _context.SaveChanges();

            return RedirectToAction("Index", "Category");
        }
    }
}
