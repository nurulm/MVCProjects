using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MVCUnitTestApp.Controllers;
using MVCUnitTestApp.Models;
using System.Web.Mvc;

namespace MVCUnitTestApp.Tests.Controllers
{
    /// <summary>
    /// Summary description for DemoControllerTest
    /// </summary>
    [TestClass]
    public class DemoControllerTest
    {
        [TestMethod]
        public void Index()
        {
            DemoController obj = new DemoController();

            ViewResult v = obj.Index() as ViewResult;

            Assert.AreEqual("Index", v.ViewName);
            
        }

        [TestMethod]
        public void Sum()
        {
            DemoController obj = new DemoController();

            ViewResult v = obj.Sum(10, 20) as ViewResult;

            Assert.AreEqual(30, v.ViewBag.res);
        }

        [TestMethod]
        public void Summ()
        {
            TestModel obj = new TestModel();

            int res = obj.sum(10, 20);

            Assert.AreEqual(30, res);
        }
    }
}
