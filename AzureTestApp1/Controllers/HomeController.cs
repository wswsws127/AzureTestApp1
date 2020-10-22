using AzureTestApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureTestApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            myTestDB2Entities te = new myTestDB2Entities();
            var lst= te.Customers.ToList();
            return View(lst);
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
    }
}