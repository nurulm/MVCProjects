using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using mvcdiappnew.Models;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

namespace mvcdiappnew
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IUnityContainer obj = new UnityContainer();
            obj.RegisterType<IEmployee,actualemployee>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(obj));





            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
