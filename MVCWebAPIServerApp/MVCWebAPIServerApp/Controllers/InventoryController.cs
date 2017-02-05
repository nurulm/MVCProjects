using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCWebAPIServerApp.Models;
using System.Web.Http.Cors;

namespace MVCWebAPIServerApp.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class InventoryController : ApiController
    {
        MVCEntities obj = new MVCEntities();

        public List<PRODUCT> getProducts()
        {
            string token = System.Web.HttpContext.Current.Request.Headers.Get("myToken");

          if (token == "xyz123")
                return obj.PRODUCTs.ToList();
           else
                return null;
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
                return "duplicate";
            }

        }

       
        public string deleteProduct(string id)
        {
            try
            {
                var p = obj.PRODUCTs.Find(id);

                obj.PRODUCTs.Remove(p);

                obj.SaveChanges();

                return "Record Deleted";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
           
        }

        [HttpPut]
        public void updateProduct(PRODUCT p)
        {
            var pp = obj.PRODUCTs.Find(p.PRODID);

            pp.PRODNAME = p.PRODNAME;
            pp.PRODPRICE = p.PRODPRICE;
            pp.CATEID = p.CATEID;

            obj.SaveChanges();
        }

    }
}
