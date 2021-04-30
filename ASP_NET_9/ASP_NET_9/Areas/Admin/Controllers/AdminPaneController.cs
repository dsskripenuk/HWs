using ASP_NET_9.Areas.Admin.Models;
using ASP_NET_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_9.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminPaneController : Controller
    {
        private ApplicationDbContext _context;

        public AdminPaneController()
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
        public ActionResult AddPost(CreatePostViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Please, enter all data!");
                return View(model);
            }
            else
            {
                _context.Posts.Add(new Entity.Post
                {
                    Author = model.Author,
                    DateRelease = model.DateRelease,
                    Text = model.Text,
                    Title = model.Title
                });
                _context.SaveChanges();

                return RedirectToAction("Dashboard", "AdminPanel", new { area = "Admin" });
            }
        }
    }
}
