using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCWebAPIServerApp.Models;

namespace MVCWebAPIServerApp.Controllers
{
    public class InventoryController : ApiController
    {
        MVCEntities obj = new MVCEntities();

        public List<PRODUCT> getProducts()
        {
            return obj.PRODUCTs.ToList();
        }

        public PRODUCT getProduct(string id)
        {
            var p = obj.PRODUCTs.Find(id);

            return p;
        }


        public string postProduct(PRODUCT p)
        {
            try
            {
                obj.PRODUCTs.Add(p);
                obj.SaveChanges();

                return "Product Added";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

        }

        public void deleteProduct(string id)
        {
            var p = obj.PRODUCTs.Find(id);

            obj.PRODUCTs.Remove(p);

            obj.SaveChanges();
           
        }

        public void putProduct(PRODUCT p)
        {
            var pp = obj.PRODUCTs.Find(p.PRODID);

            pp.PRODNAME = p.PRODNAME;
            pp.PRODPRICE = p.PRODPRICE;
            pp.CATEID = p.CATEID;

            obj.SaveChanges();
        }

    }
}
