using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHTMLHelperApp.Models;

namespace MVCHTMLHelperApp.Controllers
{
    public class HomeController : Controller
    {
        CustomerModel CustModel = new CustomerModel();

        List<CustomerModel> CModel = new List<CustomerModel>();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Store(FormCollection f)
        {
            ReadValues(f);
            return View(CustModel);
        }

        public ActionResult ShowCustomers(FormCollection f)
        {
            ReadValues(f);

            

            return View("Index", CModel);
        }

        public void ReadValues(FormCollection f)
        {
            if(TempData["Customers"] != null)
                CModel = (List<CustomerModel>)TempData["Customers"];

            string Amenities = "";
            CustModel.CustomerName = f["txtCustomerName"];
            CustModel.RoomType = f["r1"];
            string g = f["Gender"];
            CustModel.CustomerGender = (Gender)Enum.Parse(typeof(Gender), f["Gender"]);

            if (f["c1"] != "false")
                Amenities = "Wifi </br>";

            if (f["c2"] != "false")
                Amenities += "Boarding";

            CustModel.Eminities = Amenities;

            CModel.Add(CustModel);

            TempData["Customers"] = CModel;
        }

    }
}