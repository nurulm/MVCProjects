﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionReturnTypesApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult m1()
        {
            return View();
        }
    }
}