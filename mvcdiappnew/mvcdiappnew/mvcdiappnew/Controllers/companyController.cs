using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcdiappnew.Models;
namespace mvcdiappnew.Controllers
{
    public class companyController : Controller
    {
        IEmployee e;
        // GET: company
        public companyController(IEmployee e1)
        {
            e = e1;
        }
        public ActionResult addemployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addemployee(empmodel ee)
        {
            e.addemp(ee);
            return View("index");
        }
        public ActionResult displayemps()
        {
            return View(e.display());
        }







        public ActionResult Index()
        {
            return View();
        }
    }
}