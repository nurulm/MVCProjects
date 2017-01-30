using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataAnnotationsApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ValidateEven(int EvenNumber)
        {
            bool Result;

            if (EvenNumber % 2 == 0)
                Result = true;
            else
                Result = false;
           
            return Json(Result, JsonRequestBehavior.AllowGet);
        }
    }
}