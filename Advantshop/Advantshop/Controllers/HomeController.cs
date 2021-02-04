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
        ShopContext db = new ShopContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Category> categorys = db.Categorys;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Categorys = categorys;
            // возвращаем представление
            return View();
        }
    }
}