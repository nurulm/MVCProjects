using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MVCAttributeroutingApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult getProductInfoByName (string id)
        {
          
            ViewBag.info = id + "  Product Info";
            return View();
        }


        [Route("Demo/getPbnp/{name}/{price:regex([1-9]|1[012])}")]
        public ActionResult getProductInfoByNamePrice(string name, string price)
        {

            ViewBag.info = name + "  " + price + " Product Info";
            return View();
        }
            
    }
}