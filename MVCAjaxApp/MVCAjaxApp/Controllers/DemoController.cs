using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using MVCAjaxApp.Models;

namespace MVCAjaxApp.Controllers
{
    public class DemoController : Controller
    {
        MVCEntities obj = new MVCEntities();
       
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CascadingDropDown()
        {
            List<SelectListItem> lItems = new List<SelectListItem>();

            lItems.Add(new SelectListItem { Text = "--Select Category--" });

            foreach(var p in obj.Categories)
            {
                lItems.Add(new SelectListItem { Text = p.CateName, Value = p.CateID });
            }

            ViewBag.CatItems = lItems;
            return View();
        }

        public JsonResult GetProducts(string cid)
        {

            var res = from p in obj.PRODUCTs
                      where p.CATEID == cid
                      select new { p.PRODID, p.PRODNAME };

            return Json(res.ToList(), JsonRequestBehavior.AllowGet);
        }

        public string getNews()
        {
            var doc = XElement.Load(Server.MapPath("/Files/News.xml"));

            string s = doc.Element("Message").Value;

            return s;

        }
    }
}