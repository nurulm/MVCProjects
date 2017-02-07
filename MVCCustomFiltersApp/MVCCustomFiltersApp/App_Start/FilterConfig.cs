﻿using System.Web;
using System.Web.Mvc;

namespace MVCCustomFiltersApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new Filters.LogFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
