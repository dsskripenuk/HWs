using ASP.NET_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_12.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            DashboardViewModel model = new DashboardViewModel();
            model.InitList();


            return View(model);
        }
    }
}