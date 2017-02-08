using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDIApp.Repository
{
    public interface IDepartment
    {
        string AddDept(int DeptId, string DeptName);
    }
}
