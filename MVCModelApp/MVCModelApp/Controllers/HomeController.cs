using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCModelApp.Models;

namespace MVCModelApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CustomerModel cust = new CustomerModel();

            cust.CustId = "100";
            cust.CustName = "Raj";

            ViewBag.CustID = cust.CustId;
            ViewBag.CustName = cust.CustName;

            return View();
        }

        public ActionResult IndexWithMode()
        {
            CustomerModel cust = new CustomerModel { CustId = "101", CustName = "Ramu" };
            return View(cust);

        }
    }
}