using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFormsAuthApp.Controllers
{
    [Authorize]
    public class SecureController : Controller
    {
        // GET: Secure
        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult Tutorials()
        {
            return View();
        }

        public ActionResult Books()
        {
            return View();
        }

        public ActionResult Logout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return View();
        }
    }
}