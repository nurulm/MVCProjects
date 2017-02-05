using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWindowsAuthApp.Controllers
{
    [Authorize(Users ="NURUL-PC\\muser1")]
    public class MKTGController : Controller
    {
        // GET: MKTG
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sales()
        {
            return View();
        }
    }
}