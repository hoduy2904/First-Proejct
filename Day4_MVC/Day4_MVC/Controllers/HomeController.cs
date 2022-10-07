using Day4_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4_MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly travelEntities db = new travelEntities();
        public ActionResult Index()
        {
            var travelAbout = db.aboutCountries.ToList();
            return View(travelAbout);
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