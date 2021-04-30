using ASP.NET_Practice_4.Entity;
using ASP.NET_Practice_4.Helper;
using ASP.NET_Practice_4.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Practice_4.Controllers
{
    public class AnimeController : Controller
    {
        private readonly EFConext _context;
        int id = 3;
        private object imageFile;

        public AnimeController()
        {
            _context = new EFConext();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<AnimeViewModel> data = _context.Anime.Select(t => new AnimeViewModel()
            {
                id = t.id,
                URL_Image = t.URL_Image,
                Title = t.Title,
                Rating = t.Rating,
                DateOfRelease = t.DateOfRelease
            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddAnimeViewModel t, HttpPostedFileBase imageFile)
        {

            string fileName = Guid.NewGuid().ToString() + ".jpg";

            string image = Server.MapPath(Constants.ImagePath) + "\\" + fileName;
            using (Bitmap img = new Bitmap(imageFile.InputStream))
            {
                Bitmap saveImage = ImageWorker.CreateImage(img, 400, 400);
                if (saveImage != null)
                {
                    saveImage.Save(image, ImageFormat.Jpeg);
                    // Save game with name image in Db
                    _context.Anime.Add(new Animes
                    {
                        URL_Image = fileName,
                        Title = t.Title,
                        Rating = t.Rating,
                        DateOfRelease = t.DateOfRelease,
                        id = id + 1
                    });
                    _context.SaveChanges();
                }
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Anime");
        }


        public ActionResult Delete(int Id)
        {
            var deleteStudent = _context.Anime.FirstOrDefault(t => t.id == Id);

            if (deleteStudent != null)
            {
                _context.Anime.Remove(deleteStudent);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Anime");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var editStudent = _context.Anime.Select(t => new AnimeViewModel
            {
                URL_Image = t.URL_Image,
                Title = t.Title,
                Rating = t.Rating,
                DateOfRelease = t.DateOfRelease,
                id = t.id
            }).FirstOrDefault(t => t.id == Id);

            if (editStudent != null)
                return View(editStudent);
            else
                return RedirectToAction("Index", "Anime");
        }

        [HttpPost]
        public ActionResult Edit(AnimeViewModel model)
        {
            var editSt = _context.Anime.FirstOrDefault(t => t.id == model.id);

            if (editSt != null)
            {
                editSt.URL_Image = model.URL_Image;
                editSt.Title = model.Title;
                editSt.Rating = model.Rating;
                editSt.DateOfRelease = model.DateOfRelease;

                _context.SaveChanges();
                return RedirectToAction("Index", "Anime");
            }
            else
                return RedirectToAction("Index", "Anime");

        }
    }
}