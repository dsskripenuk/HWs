using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Areas.Admin.Models;
using University.Models;

namespace University.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;
        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPost(AddGroupViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Please, enter all data!");
                return View(model);
            }
            else
            {
                _context.Groups.Add(new Entity.Group_St
                {
                    Title = model.Title
                });

                _context.SaveChanges();

                return RedirectToAction("Dashboard", "AdminPanel", new { area = "Admin" });
            }
        }
    }
}