using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWindowsAuthApp.Controllers
{
    [Authorize(Users ="NURUL-PC\\huser1")]
    public class HRDController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: HRD
        public ActionResult AddEmp()
        {
            return View();
        }
    }
}