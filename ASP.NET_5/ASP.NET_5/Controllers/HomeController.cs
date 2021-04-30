using ASP.NET_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult CreateStudents()
        {
            StudentViewModel model = new StudentViewModel();
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
        public ActionResult CreateStudent(StudentViewModel model)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
