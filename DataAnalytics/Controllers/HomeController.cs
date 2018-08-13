using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnalytics.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Chart()
        {
            ViewBag.Title = "Chart Page";

            return View();
        }
        public ActionResult Signin()
        {
            ViewBag.Title = "Signin Page";

            return View();
        }
        public ActionResult Signup()
        {
            ViewBag.Title = "Signup Page";

            return View();
        }
        public ActionResult Portfolio()
        {
            ViewBag.Title = "Portfolio Page";

            return View();
        }
    }
}
