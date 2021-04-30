using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University_Manager_HW.Controllers
{
    public class UniversityController : Controller
    {
        [Authorize(Roles = "Student")]
        public ActionResult StudentPanel()
        {
            return View();
        }

        [Authorize(Roles = "Teacher")]
        public ActionResult TeacherPanel()
        {
            return View();
        }
    }
}
