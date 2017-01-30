using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDataAnnotationsApp.Models;

namespace MVCDataAnnotationsApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Store(Employee e)
        {
            return View();
        }
    }
}