using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFormsAuthApp.Models;

namespace MVCFormsAuthApp.Controllers
{
    public class HomeController : Controller
    {
        MVCEntities obj = new MVCEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(user u)
        {
            obj.users.Add(u);
            obj.SaveChanges();
            return View("feedback");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(user u)
        {
            bool b = false;

            if (Request.Form["c1"] == "on")
                b = true;

            //Validate User Account
            var res = obj.users.Where(u1 => u1.username == u.username && u1.password == u.password);

            if(res.Count()==0)
            {
                ViewBag.Message = "Invalid User or Password";
                return View("Login");
            }
            else
            {
                TempData["name"] = u.username;
                System.Web.Security.FormsAuthentication.SetAuthCookie(u.username, b);
                return RedirectToAction("Welcome", "Secure");
            }
        }
    }
}