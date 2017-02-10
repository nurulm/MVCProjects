using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUnitTestApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Sum(int a, int b)
        {
            int res = a + b;
            ViewBag.res = res;
            return View();
        }
    }
}