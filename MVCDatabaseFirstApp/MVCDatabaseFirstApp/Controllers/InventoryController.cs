using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDatabaseFirstApp.Models;

namespace MVCDatabaseFirstApp.Controllers
{
    public class InventoryController : Controller
    {
        MVCEntities obj = new MVCEntities();
        

        public ActionResult AddProduct()
        {
            return PartialView();
        }
        // GET: Inventory
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AccordianView()
        {
            return View(obj.Categories.ToList());
        }

        [HttpPost]
        public ActionResult AddProduct (PRODUCT p)
        {
            obj.ADDPRODUCT(p.PRODID, p.PRODNAME, p.PRODPRICE, p.CATEID);

            return View("Index");
               
        }

        public ActionResult DisplayProduct ()
        {
            List<PRODUCT> ProdInf = obj.PRODUCTs.ToList();

            return PartialView(ProdInf);
        }

        public ActionResult EditProduct(string id)
        {
            PRODUCT p = obj.PRODUCTs.Find(id);

            return PartialView(p);
        }

        [HttpPost]
        public ActionResult EditProduct(PRODUCT p)
        {
            PRODUCT prd = obj.PRODUCTs.Find(p.PRODID);

            prd.PRODNAME = p.PRODNAME;
            prd.PRODPRICE = p.PRODPRICE;

            obj.SaveChanges();

            return View("Index");
        }

        public ActionResult DeleteProduct(string id)
        {
            PRODUCT p = obj.PRODUCTs.Find(id);

            obj.PRODUCTs.Remove(p);

            obj.SaveChanges();

            return PartialView("DisplayProduct", obj.PRODUCTs.ToList());
        }

        public ActionResult AddCategory()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            obj.Categories.Add(c);

            obj.SaveChanges();
            return PartialView("Index");
        }

        public ActionResult DisplayCategory()
        {
            return PartialView(obj.Categories.ToList());
        }

        public ActionResult EditCategory(string id)
        {
            Category c = obj.Categories.Find(id);

            return PartialView(c);
        }

        [HttpPost]
        public ActionResult EditCategory(Category c)
        {
            Category cat = obj.Categories.Find(c.CateID);

            cat.CateName = c.CateName;

            obj.SaveChanges();

            return View("Index");
        }

        public ActionResult DeleteCategory(string id)
        {
            Category c = obj.Categories.Find(id);

            obj.Categories.Remove(c);

            obj.SaveChanges();

            return PartialView("DisplayCategory",obj.Categories.ToList());
        }
    }
}