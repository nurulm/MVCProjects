using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdiappnew.Models
{
    public class fakeemployee : IEmployee
    {
        public void addemp(empmodel e)
        {
            List<empmodel> obj = (List<empmodel>)System.Web.HttpContext.Current.Session["info"];
            if (obj == null)
            {
                obj = new List<empmodel>();
            }
            obj.Add(new empmodel { empno = e.empno, ename = e.ename });
            System.Web.HttpContext.Current.Session["info"] = obj;
        }
        public List<empmodel> display()
        {
            List<empmodel> obj = (List<empmodel>)System.Web.HttpContext.Current.Session["info"];
            return (obj);
        }





    }
}