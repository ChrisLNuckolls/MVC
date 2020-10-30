using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CareyWeddingPart2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Venue()
        {
            ViewBag.Message = "The Wedding Venue";

            return View();
        }

        public ActionResult Accommodations()
        {
            ViewBag.Message = "Our Host Hotel";

            return View();
        }

        public ActionResult ThingsToDo()
        {
            return View();
        }
    }
}