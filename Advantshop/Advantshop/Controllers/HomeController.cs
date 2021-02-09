using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Advantshop.Models;

namespace Advantshop.Controllers
{
    public class HomeController : Controller
    {
        readonly ModelCF db = new ModelCF();

        readonly AdvantshopEntities bd = new AdvantshopEntities();

        readonly Model1 database = new Model1();

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