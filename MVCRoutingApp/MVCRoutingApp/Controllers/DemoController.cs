using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRoutingApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReportByMonth(int id)
        {
            ViewBag.info = id + " Month Report Info";

            return View();
        }

        public ActionResult GetReportByMonthYear(int month, int year)
        {
            ViewBag.info = month + " / " + year + " Report Info";

            return View();
        }
    }
}