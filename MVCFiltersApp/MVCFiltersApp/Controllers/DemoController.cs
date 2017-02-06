using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFiltersApp.Models;

namespace MVCFiltersApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FileNotFound()
        {
            return View();
        }

        [NonAction]
        public ActionResult Tutorials()
        {
            return View();
        }

        public ActionResult Books()
        {
            return View();
        }

        public ActionResult BlogReader()
        {
            return View();
        }

     //   [ValidateInput(false)]
        public ActionResult Store(BlogReader b)
        {
            return View(b);
        }
    }
}