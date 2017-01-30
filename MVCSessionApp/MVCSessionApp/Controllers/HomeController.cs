using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSessionApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["css"] = "";
            return View();
        }

        public ActionResult Store()
        {
            Session["css"] = Request.Form["ddlTheme"];
            return View("Index");
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }
    }
}