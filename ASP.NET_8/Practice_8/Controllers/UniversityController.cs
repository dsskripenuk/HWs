using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_8.Controllers
{
    public class UniversityController : Controller
    {
        // GET: University
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize(Roles = "Admin")]
        //public ActionResult StList()
        //{
        //    //List<UserViewModel> data = _context.Student.Select(t => new UserViewModel()
        //    //{
        //    //    id = t.id,
        //    //    URL_Image = t.URL_Image,
        //    //    Title = t.Title
        //    //}).ToList();

        //    //return View(data);

        //}

        //[Authorize(Roles = "Admin")]
        //public ActionResult TeacherList()
        //{
        //    //List<TeacherViewModel> data = _context.Teacher.Select(t => new TeacherViewModel()
        //    //{
        //    //    id = t.id,
        //    //    URL_Image = t.URL_Image,
        //    //    Title = t.Title
        //    //}).ToList();

        //    //return View(data);

        //}



    }
}