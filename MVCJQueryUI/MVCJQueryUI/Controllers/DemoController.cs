using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCJQueryUI.Models;

namespace MVCJQueryUI.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index1()
        {

            return View();
        }

        public ActionResult EventDemo()
        {
            List<string> Publisher = new List<string>();

            Publisher.Add("Microsoft");
            Publisher.Add("WROX");

            ViewBag.Publisher = Publisher;

            return View();
        }

        public ActionResult ValidationsDemo()
        {

            return View();
        }

        public ActionResult Store(CustomerModel c)
        {
            return View(c);
        }
    }
}