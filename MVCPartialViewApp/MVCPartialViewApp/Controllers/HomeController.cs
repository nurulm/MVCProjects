using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPartialViewApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Campus()
        {
            return View();
        }

        public ActionResult ClassRooms()
        {
            return View();
        }


        public ActionResult Lab()
        {
            return View();
        }

        public ActionResult Auditorium()
        {
            return View();
        }
    }
}