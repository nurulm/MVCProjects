﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLayoutApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUS()
        {
            return View();
        }

        public ActionResult ContactUS()
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
    }
}