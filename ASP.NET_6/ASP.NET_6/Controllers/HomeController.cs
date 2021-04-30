using ASP.NET_6.Helper;
using ASP.NET_6.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_6.Controllers
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
        public ActionResult CreateGame()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateGame(CreateGameViewModel model, HttpPostedFileBase imageFile)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string image = Server.MapPath(Constants.ImagePath) + "\\" + fileName;

            using (Bitmap img = new Bitmap(imageFile.InputStream))
            {
                Bitmap saveImage = ImageWorker.CreateImage(img, 400, 400);

                if(saveImage != null)
                    saveImage.Save(image, ImageFormat.Jpeg);
            }

                return RedirectToAction("Index", "Home");
        }
    }
}