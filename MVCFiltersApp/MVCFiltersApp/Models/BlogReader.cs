using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFiltersApp.Models
{
    public class BlogReader
    {
        public string Name { get; set; }

        [AllowHtml]
        public string Comments { get; set; }
    }
}