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


        public ActionResult AjaxAutoImplementation()
        {
            return View();
        }

        public JsonResult GetProductsList(string s)
        {//Param will recieve characters typed in the text box
            var res = from p in obj.PRODUCTs
                      where p.PRODNAME.StartsWith(s)
                      select new { p.PRODID, p.PRODNAME };

            return Json(res.ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetProduct(string id)
        {//Param id will recieve the id from more link

            var p = obj.PRODUCTs.Find(id);

            return View(p);
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