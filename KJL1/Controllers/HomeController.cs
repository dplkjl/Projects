using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KJL1.Models;

namespace KJL1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
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
        [HttpPost]
        public ActionResult InputNewCustomer(Customer newCustomer)
        {

            newCustomer.AddNewCustomer();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult InputNewProduct(Product newProduct)
        {

            newProduct.AddNewProduct();

            return RedirectToAction("Index");
        }
    }
}