using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouTube.Areas.Admin.Models;
using YouTube.Models;

namespace YouTube.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext _context;

        public ActionResult Index()
        {
            List<YouTube.Models.UserViewModel_> data = _context.Users_.Select(t => new YouTube.Models.UserViewModel_()
            {
                ChannelName = t.ChannelName,
                Id = t.Id,
                ProfilePhoto = t.ProfilePhoto,
                MainPhoto = t.MainPhoto,
                ChannelDescription = t.ChannelDescription,
                CategoryId = t.CategoryId
            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddUserViewModel t)
        {
            _context.Users_.Add(new Entity.User_
            {
                ChannelName = t.ChannelName,
                ProfilePhoto = t.ProfilePhoto,
                MainPhoto = t.MainPhoto,
                ChannelDescription = t.ChannelDescription,
                CategoryId = t.CategoryId
            });

            _context.SaveChanges();

            return RedirectToAction("Index", "User");
        }

        public ActionResult Delete(int Id)
        {
            var delQuest = _context.Users_.FirstOrDefault(t => t.Id == Id);

            if (delQuest != null)
            {
                _context.Users_.Remove(delQuest);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "User");
        }
    }
}