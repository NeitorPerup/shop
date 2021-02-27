using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Advantshop.Models;

namespace Advantshop.Controllers
{
    public class HomeController : Controller
    {
        readonly ModelDataBase database = new ModelDataBase();

        public ActionResult Index()
        {
            Session["name"] = "test";

            IEnumerable<Product> product = database.Product.Take(100);
            IEnumerable<Category1> ctg = database.Category1.Take(9);

            ViewBag.Category = ctg;
            //ViewBag.Product = product;

            ViewBag.ProductHit = (IEnumerable<Product>)product.Where(rec => rec.Bestseller == true).Take(3);
            ViewBag.ProductNew = (IEnumerable<Product>)product.Where(rec => rec.New == true).Take(3);

            return View();
        }

        [HttpGet]
        public void InBusket(int id)
        {
            ViewBag.ProductId = id;

            Order order = new Order();
            order.ProductId = id;
            order.Id = database.Order.Count() > 0 ? database.Order.Max(rec => rec.Id) + 1 : 1;
            order.Date = DateTime.Now;
            order.Number = 1;
            //order.Cost = database.Product.FirstOrDefault(rec => rec.Id == order.ProductId).Price * order.Number;
            order.Person = Session["name"].ToString();

            Session["ProductId"] = order.ProductId;
            Session["OrderNumber"] = order.Number;
            Session["OrderCost"] = order.Cost;
            database.Order.Add(order);
        }

        protected void InBasket_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ViewBag.ProductId = Convert.ToInt32(b.ID);

            Order order = new Order();
            order.ProductId = Convert.ToInt32(b.ID);
            order.Id = database.Order.Count() > 0 ? database.Order.Max(rec => rec.Id) + 1 : 1;
            order.Date = DateTime.Now;
            order.Number = 1;
            //order.Cost = database.Product.FirstOrDefault(rec => rec.Id == order.ProductId).Price * order.Number;
            order.Person = Session["name"].ToString();

            Session["ProductId"] = order.ProductId;
            Session["OrderNumber"] = order.Number;
            Session["OrderCost"] = order.Cost;
            database.Order.Add(order);
        }
        //[HttpPost]
        public ActionResult Busket()
        {
            int ProductId = (int)Session["ProductId"];
            //Product pr = database.Product.FirstOrDefault(rec => rec.Id == ProductId);
            //ViewBag.ProductUrl = pr.UrlPath;
            //ViewBag.ProductPrice = pr.Price;
            //ViewBag.ProductName = pr.Name;
            // сохраняем в бд все изменения
            //database.SaveChanges();
            return View();
        }
    }
}