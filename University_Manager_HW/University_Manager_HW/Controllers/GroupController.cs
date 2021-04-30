using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University_Manager_HW.Models;

namespace University_Manager_HW.Controllers
{
    public class GroupController : Controller
    {
        private ApplicationDbContext _context;

        public GroupController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}