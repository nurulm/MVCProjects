using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC6TagHelpersApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC6TagHelpersApp.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC6TagHelpersApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<SelectListItem> obj1 = new List<SelectListItem>();

            obj1.Add(new SelectListItem { Text = ".NET", Value=".NET" });
            obj1.Add(new SelectListItem { Text = "JAVA", Value = "JAVA" });
            obj1.Add(new SelectListItem { Text = "PHP", Value = "PHP" });


            List<string> obj2 = new List<string>();

            obj2.Add("--Select Country--");
            obj2.Add("India");
            obj2.Add("USA");
            obj2.Add("Japan");

            ViewBag.SkillSets = obj1;
            ViewBag.Countries = obj2;
            return View();
        }

        public ActionResult Store(UserModel u)
        {
            u.SkillSet = Request.Form["SkillSet"];

            UserModel.MongoConnect();

            if (ModelState.IsValid)
                return View(u);
            else
                return View("Index");
        }
    }
}
