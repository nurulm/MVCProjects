using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTypedHTMLControls.Models;

namespace MVCTypedHTMLControls.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<SelectListItem> obj1 = new List<SelectListItem>();

            obj1.Add(new SelectListItem { Text = "India", Value = "IND" });
            obj1.Add(new SelectListItem { Text = "United States", Value = "USA" });
            obj1.Add(new SelectListItem { Text = "Britan", Value = "BRT" });

            List<string> obj2 = new List<string>();

            obj2.Add(".NET");
            obj2.Add("MVC");
            obj2.Add("JAVA");
            obj2.Add("PHP");

            ViewBag.Countries = obj1;
            ViewBag.SkillSets = obj2;

            return View();
        }

        public ActionResult Store(JobModel j)
        {
            //Parameter J will Recieve controls data from index view. Controls data will be assigned to model properties
            
            return View(j);
        }
    }
}