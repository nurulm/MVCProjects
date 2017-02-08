using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDIApp.Repository;

namespace MVCDIApp.Models
{
    public class fakeEmployee : IEmployee
    {
        public string AddEmp(int empid, string empname)
        {
            string s = string.Format("Fake EMP EmpId:{0}  EmpName:{1}", empid, empname);

            return s;
        }
    }
}