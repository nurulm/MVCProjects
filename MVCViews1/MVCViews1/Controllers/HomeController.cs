using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCViews1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUS()
        {
            //return Redirect("http://www.facebook.com");
            return View();
        }

        public ActionResult ContactUS()
        {
            return View();
        }

    }
}