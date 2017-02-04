using CatalogConstructor.Models;
using CatalogConstructor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatalogConstructor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            using (ParfumeContext db = new ParfumeContext())
            {
                var brands = db.Brands;
                foreach (Brand brand in brands)
                {
                    
                }
                ViewBag.Brands = brands;
            }
            return View();
        }
    }
}
