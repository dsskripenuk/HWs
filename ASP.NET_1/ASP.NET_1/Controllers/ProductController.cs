using ASP.NET_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult List()
        {
            List<ProductViewModel> model = new List<ProductViewModel>();
            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png"
            });

            return View(model);
        }
    }
}