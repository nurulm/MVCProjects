using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplicatonObjectApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Store()
        {
            HttpContext.Application["Comments"] = HttpContext.Application["Comments"].ToString() + Request.Form["txtComment"] + "<hr>";
            return View("index");
        }
    }
}