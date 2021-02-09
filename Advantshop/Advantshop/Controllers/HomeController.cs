using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Advantshop.Controllers
{
    public class HomeController : Controller
    {
        readonly ModelDb database = new ModelDb();

        public ActionResult Index()
        {
            IEnumerable<Product> product = database.Product;
            IEnumerable<Category> ctg = database.Category;

            ViewBag.Category = ctg;
            ViewBag.Product = product;
            
            return View();
        }
    }
}