using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDIApp.Repository;

namespace MVCDIApp.Controllers
{
    public class CompanyController : Controller
    {
        IDepartment d;
        IEmployee e;

        public CompanyController(IDepartment id, IEmployee ie)
        {
            d = id;
            e = ie;
        }
        // GET: Company
        public ActionResult Index()
        {
            ViewBag.dinfo = d.AddDept(10, "Acounts");
            return View();
        }

        public ActionResult Index1()
        {
            ViewBag.einfo = e.AddEmp(100, "Raj");
            return View();
        }

    }
}