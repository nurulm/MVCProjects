using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCRoutingApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "YearMonth",
                url: "{controller}/{action}/{month}/{year}",
                defaults:new { },
                constraints: new { month = "[1-9]|1[012]", year = "\\d{4}" }
            //   defaults: new { controller = "Home", action = "GetReportByMonthYear", id = UrlParameter.Optional }
            );
        }
    }
}
