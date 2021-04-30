using ASP.NET_2.Enitity;
using ASP.NET_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_2.Controllers
{
    public class StudentController : Controller
    {
        private readonly EFContext _context;

        public StudentController()
        {
            _context = new EFContext();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<StudentViewModel> data = _context.Students.Select(t => new StudentViewModel()
            {
                Id = t.Id,
                Address = t.Address,
                Age = t.Age,
                FullName = t.FullName,
                URL_Img = t.URL_Img,
            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddStudentViewModel model)
        {
            _context.Students.Add(new Student
            {
                Address = model.Address,
                Age = model.Age,
                FullName = model.FullName,
                URL_Img = model.URL_Img,
            });
            _context.SaveChanges();

            return RedirectToAction("Index", "Student");
        }
    }
}