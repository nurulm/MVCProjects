using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMobileAppDisplayModeApproach.Controllers
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
            if(Request.Browser.IsMobileDevice)
            {
                ViewBag.minfo = "Mobile View Data";
                return View("mobileview");
            }
            else
            {
                ViewBag.dinfo = "Desktop View Data";
                return View("desktopview");
            }
        }
    }
}