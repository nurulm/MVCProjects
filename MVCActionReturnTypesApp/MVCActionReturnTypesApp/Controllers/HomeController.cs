using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionReturnTypesApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult ContentDemo()
        {
            return Content("Welcome Content");
        }

        public ViewResult ViewResultDemo()
        {
            return View();
        }

        public RedirectToRouteResult RedirectRouteDemo()
        {
            return RedirectToAction("m1", "demo");
        }

        public RedirectResult RedirectResultDemo()
        {
            return Redirect("http://www.facebook.com");
        }


        public FileResult FileDemo()
        {
            return File("^/Videos/movie1.mp4", "video/mp4", "x");
        }
        

        public JsonResult JsonDemo()
        {
            List<string> obj = new List<string>();
            obj.Add("asp.net");
            obj.Add("C#");
            obj.Add("VB.NET");
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}