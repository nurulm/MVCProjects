using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCachingApp.Models;

namespace MVCCachingApp.Controllers
{
    public class DemoController : Controller
    {
        MVCEntities obj = new MVCEntities();
        // GET: Demo
        [OutputCache(Duration =300)]
        public ActionResult Index()
        {
            return View(obj.PRODUCTs.ToList());
        }


        public ActionResult VaryByParam()
        {
            List<SelectListItem> cs = new List<SelectListItem>();

            cs.Add(new SelectListItem { Text = "--Select Category--" });

            foreach (var c in obj.Categories)
            {
                cs.Add(new SelectListItem { Text = c.CateName, Value = c.CateID });
            }
            ViewBag.cinfo = cs;

            return View();
        }

        [OutputCache(Duration =300, VaryByParam ="cid")]
        public ActionResult getProducts(string cid)
        {
            var res = obj.PRODUCTs.Where(p => p.CATEID == cid);

            ViewBag.cateid = cid;

            return PartialView(res);
        }
    }
}