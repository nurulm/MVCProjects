﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDIApp.Repository;

namespace MVCDIApp.Models
{
    public class fakeDepartment :IDepartment
    {
        public string AddDept(int deptid, string deptname)
        {
            string s = string.Format("Fake Department DEPTID: {0}  Dname:{1}", deptid, deptname);
            return s;
        }
    }
}