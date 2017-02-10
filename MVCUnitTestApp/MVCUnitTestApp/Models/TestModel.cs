using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCUnitTestApp.Models
{
    public class TestModel
    {
        public int sum(int a, int b)
        {
            int res = a + b;
            return (res);
        }
    }
}