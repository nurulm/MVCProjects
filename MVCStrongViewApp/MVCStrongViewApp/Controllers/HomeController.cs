using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStrongViewApp.Models;

namespace MVCStrongViewApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StudentModel sModel = new StudentModel() { StudID = "1000", StudName = "Raj", StudPhoto = "1.jpg" };
          
            return View(sModel);
        }

        public ActionResult Index1()
        {
            List<StudentModel> StudentsObj = new List<StudentModel>();

            StudentsObj.Add(new StudentModel { StudID = "1000", StudName = "Raj", StudPhoto = "1.jpg" });
            StudentsObj.Add(new StudentModel { StudID = "1001", StudName = "Ravi", StudPhoto = "2.jpg" });

            return View(StudentsObj);
        }
    }
}