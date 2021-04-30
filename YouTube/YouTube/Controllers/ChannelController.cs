using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouTube.Entity;
using YouTube.Models;

namespace YouTube.Controllers
{
    public class ChannelController : Controller
    {
        private ApplicationDbContext _context;

        public ChannelController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListVideos()
        {
            var data = _context.Videos.Select(t => new VideoViewModel
            {
                Id = t.Id,
                Title = t.Title,
                UserId = t.UserId,
                Img = t.Img
            });

            return View(data);
        }

        [HttpGet]
        [Authorize]
        public ActionResult AddPost()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddVideo(AddVideoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Please, enter all data!");
                return View(model);
            }
            else
            {
                _context.Videos.Add(new Video
                {
                    Title = model.Title,
                    Img = model.Img,
                    UserId = model.UserId
                });

                _context.SaveChanges();

                return RedirectToAction("ListVideos", "Channel");
            }
        }

        [Authorize]
        public ActionResult Delete(int Id)
        {
            var delQuest = _context.Videos.FirstOrDefault(t => t.Id == Id);

            if (delQuest != null)
            {
                _context.Videos.Remove(delQuest);
                _context.SaveChanges();
            }

            return RedirectToAction("ListVideos", "Channel");
        }

        [HttpGet]
        [Authorize]
        public ActionResult Edit(int Id)
        {
            var editQuest = _context.Videos.Select(t => new VideoViewModel
            {
                Title = t.Title,
                Id = t.Id,
                Img = t.Img,
                UserId = t.UserId
            }).FirstOrDefault(t => t.Id == Id);

            if (editQuest != null)
                return View(editQuest);
            else
                return RedirectToAction("ListVideos", "Channel");
        }

        [HttpPost]
        [Authorize]
        public ActionResult Edit(VideoViewModel model)
        {
            var editVideo = _context.Videos.FirstOrDefault(t => t.Id == model.Id);

            if (editVideo != null)
            {
                editVideo.Id = model.Id;
                editVideo.Title = model.Title;
                editVideo.UserId = model.UserId;
                editVideo.Img = model.Img;

                _context.SaveChanges();
                return RedirectToAction("ListVideos", "Channel");
            }
            else
                return RedirectToAction("ListVideos", "Channel");
        }
    }
}
