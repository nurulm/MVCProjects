using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdiappnew.Models
{
    public interface IEmployee
    {
        void addemp(empmodel  e);
        List<empmodel> display();
    }
}