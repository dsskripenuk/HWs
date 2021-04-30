using ASP.NET_3.Entity;
using ASP.NET_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_3.Controllers
{
    public class ActorController : Controller
    {
        private readonly EFConext _context;
        int id = 3;
        public ActorController()
        {
            _context = new EFConext();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<ActorViewModel> data = _context.Actors.Select(t => new ActorViewModel()
            {
                id = t.id,
                Age = t.Age,
                FullName = t.FullName,
                URL_Image = t.URL_Image,
                BirthDate = t.BirthDate,
                Rating = t.Rating,
                Gender = t.Gender,
                ListWithWorks = t.ListWithWorks
            }).ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddActorViewModel model)
        {

            _context.Actors.Add(new Actor
            {
                
                Age = model.Age,
                FullName = model.FullName,
                URL_Image = model.URL_Image,
                BirthDate = model.BirthDate,
                Rating = model.Rating,
                Gender = model.Gender,
                ListWithWorks = model.ListWithWorks,
                id = id + 1
            });
            _context.SaveChanges();
            return RedirectToAction("Index", "Actor");
        }

        public ActionResult Delete(int Id)
        {
            var deleteStudent = _context.Actors.FirstOrDefault(t => t.id == Id);

            if (deleteStudent != null)
            {
                _context.Actors.Remove(deleteStudent);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Actor");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var editStudent = _context.Actors.Select(s => new ActorViewModel
            {
                Age = s.Age,
                FullName = s.FullName,
                id = s.id,
                URL_Image = s.URL_Image,
                BirthDate = s.BirthDate,
                Rating = s.Rating,
                Gender = s.Gender,
                ListWithWorks = s.ListWithWorks
            }).FirstOrDefault(t => t.id == Id);

            if (editStudent != null)
                return View(editStudent);
            else
                return RedirectToAction("Index", "Actor");
        }

        [HttpPost]
        public ActionResult Edit(ActorViewModel model)
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
                editSt.ListWithWorks = model.ListWithWorks;

                _context.SaveChanges();
                return RedirectToAction("Index", "Actor");
            }
            else
                return RedirectToAction("Index", "Actor");

        }

    }
}