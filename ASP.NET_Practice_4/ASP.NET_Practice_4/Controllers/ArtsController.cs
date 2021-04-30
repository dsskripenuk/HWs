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
    public class ArtsController : Controller
    {
        private readonly EFConext _context;
        int id = 3;

        public ArtsController()
        {
            _context = new EFConext();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<ArtViewModel> data = _context.Art.Select(t => new ArtViewModel()
            {
                id = t.id,
                URL_Image = t.URL_Image,
                Title = t.Title
            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddArtViewModel t, HttpPostedFileBase imageFile)
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
                    _context.Art.Add(new Arts
                    {
                        URL_Image = fileName,
                        Title = t.Title,
                        id = id + 1
                    });
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Arts");
        }


        public ActionResult Delete(int Id)
        {
            var deleteStudent = _context.Art.FirstOrDefault(t => t.id == Id);

            if (deleteStudent != null)
            {
                _context.Art.Remove(deleteStudent);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Arts");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var editStudent = _context.Art.Select(t => new ArtViewModel
            {
                URL_Image = t.URL_Image,
                Title = t.Title,
                id = t.id
            }).FirstOrDefault(t => t.id == Id);

            if (editStudent != null)
                return View(editStudent);
            else
                return RedirectToAction("Index", "Arts");
        }

        [HttpPost]
        public ActionResult Edit(ArtViewModel model)
        {
            var editSt = _context.Art.FirstOrDefault(t => t.id == model.id);

            if (editSt != null)
            {
                editSt.URL_Image = model.URL_Image;
                editSt.Title = model.Title;

                _context.SaveChanges();
                return RedirectToAction("Index", "Arts");
            }
            else
                return RedirectToAction("Index", "Arts");

        }
    }
}