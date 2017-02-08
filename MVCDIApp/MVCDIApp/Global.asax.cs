using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using MVCDIApp.Repository;
using MVCDIApp.Models;
using Unity.Mvc5;
using Microsoft.Practices.Unity;

namespace MVCDIApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Implement DI

            IUnityContainer obj = new UnityContainer();

            //Registering Classes with interfaces
            obj.RegisterType<IDepartment, ActualDepartment>();
            obj.RegisterType<IEmployee, ActualEmployee>();

            //This will inject registered unity object to an interace var of controller constructor
            DependencyResolver.SetResolver(new UnityDependencyResolver(obj));


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
