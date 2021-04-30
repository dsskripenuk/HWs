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
    public class CharacterController : Controller
    {
        private readonly EFConext _context;
        int id = 3;

        public CharacterController()
        {
            _context = new EFConext();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<CharacterViewModel> data = _context.Actors.Select(t => new CharacterViewModel()
            {
                id = t.id,
                Age = t.Age,
                FullName = t.FullName,
                URL_Image = t.URL_Image,
                BirthDate = t.BirthDate,
                Rating = t.Rating,
                Gender = t.Gender,
            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            AddCharacterViewModel model = new AddCharacterViewModel();
            model.Genders = new List<SelectListItem>();
            model.Genders.Add(new SelectListItem
            {
                Value = "Male",
                Text = "Male"
                
            });

            model.Genders.Add(new SelectListItem
            {
                Value = "Female",
                Text = "Female"
            });

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(AddCharacterViewModel model, HttpPostedFileBase imageFile)
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
                    _context.Actors.Add(new Character
                    {
                        Age = model.Age,
                        FullName = model.FullName,
                        URL_Image = fileName,
                        BirthDate = model.BirthDate,
                        Rating = model.Rating,
                        Gender = model.Gender,
                        id = id + 1
                    });
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Character");
        }


        public ActionResult Delete(int Id)
        {
            var deleteStudent = _context.Actors.FirstOrDefault(t => t.id == Id);

            if (deleteStudent != null)
            {
                _context.Actors.Remove(deleteStudent);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Character");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var editStudent = _context.Actors.Select(s => new CharacterViewModel
            {
                Age = s.Age,
                FullName = s.FullName,
                id = s.id,
                URL_Image = s.URL_Image,
                BirthDate = s.BirthDate,
                Rating = s.Rating,
                Gender = s.Gender
            }).FirstOrDefault(t => t.id == Id);

            editStudent.Genders = new List<SelectListItem>();
            editStudent.Genders.Add(new SelectListItem
            {
                Value = "Male",
                Text = "Male"

            });

            editStudent.Genders.Add(new SelectListItem
            {
                Value = "Female",
                Text = "Female"
            });

            if (editStudent != null)
                return View(editStudent);
            else
                return RedirectToAction("Index", "Character");
        }

        [HttpPost]
        public ActionResult Edit(CharacterViewModel model)
        {
            var editSt = _context.Actors.FirstOrDefault(t => t.id == model.id);

            if (editSt != null)
            {
                editSt.Age = model.Age;
                editSt.URL_Image = model.URL_Image;
                editSt.FullName = model.FullName;
                editSt.Rating = model.Rating;
                editSt.BirthDate = model.BirthDate;
                editSt.Gender = model.Gender;

                _context.SaveChanges();
                return RedirectToAction("Index", "Character");
            }
            else
                return RedirectToAction("Index", "Character");

        }

    }
}