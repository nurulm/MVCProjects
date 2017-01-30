using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThemesAppUsingTempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["css"] = "";
            return View();
        }

        public ActionResult FormSubmit(FormCollection f)
        {
            TempData["css"] = Request.Form["ddlTheme"];
            return View("Index");
        }

        public ActionResult ShowIndexPage()
        {
            return View("Index");
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult HomePage()
        {
            return View();
        }
    }
}