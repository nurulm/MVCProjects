using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC6RoutingApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult getInfoByName(string id)
        {
            ViewBag.info = id + "  Product Details";
            return View();
        }

        public ActionResult getInfoByNamePrice(string name, int price)
        {
            ViewBag.info = name + "      " + price + " Product Details";
            return View();
        }

        [Route("demo1/gcnp/{catename}/{name}/{price}")]
        public ActionResult getInfoByCategoryNamePrice(string catename, string name, string price)
        {
            ViewBag.info = catename + " Name" + name + " Price:" + price + " details";
            return View();
        }
    }
}
