using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MVCCustomFiltersApp.Filters
{
    public class LogFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string cname = filterContext.RouteData.Values["controller"].ToString();

            string aname = filterContext.RouteData.Values["action"].ToString();

            string datetimeinfo = DateTime.Now.ToString();

            string info = "Controller :" + cname + "  Action:" + aname + "  DateTime:" + datetimeinfo;

            StreamWriter sw = File.AppendText(System.Web.HttpContext.Current.Server.MapPath("/Files/UserLogs.txt"));

            sw.WriteLine(info);
            sw.WriteLine("=========================================================================================");
            sw.Close();
        }
    }
}