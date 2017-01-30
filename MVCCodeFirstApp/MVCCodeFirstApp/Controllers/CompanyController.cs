using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCodeFirstApp.Models;

namespace MVCCodeFirstApp.Controllers
{
    public class CompanyController : Controller
    {
        CompanyDBContext obj = new CompanyDBContext();
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDept()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDept(Department d)
        {
            obj.Dept.Add(d);
            obj.SaveChanges();

            return View("Index");
        }

        public ActionResult DisplayDepts()
        {
            return View(obj.Dept.ToList());
        }

        public ActionResult EditDept(int id)
        {
            var deptinfo = obj.Dept.Find(id);
            return View(deptinfo);
        }

        [HttpPost]
        public ActionResult EditDept(Department d)
        {
            Department dept = obj.Dept.Find(d.DeptID);

            dept.DeptName = d.DeptName;

            obj.SaveChanges();

            return View("DisplayDepts",obj.Dept.ToList());
        }

        public ActionResult DeleteDept(int id)
        {
            Department dept = obj.Dept.Find(id);

            obj.Dept.Remove(dept);

            return View("DisplayDepts",obj.Dept.ToList());
        }

        public ActionResult AddEmp()
        {
            List<SelectListItem> ds = new List<SelectListItem>();
            
            foreach(var d in obj.Dept)
            {
                ds.Add(new SelectListItem { Text = d.DeptName, Value = d.DeptID.ToString() });
            }

            ViewBag.DeptList = ds;
            return View();
        }

     

        [HttpPost]
        public ActionResult AddEmp(Employee e)
        {
            obj.Emp.Add(e);
            obj.SaveChanges();

            return View("Index");
        }

        public ActionResult DisplayEmps()
        {
            List<Department> ds = new List<Department>();

            foreach (var d in obj.Dept)
            {
                ds.Add(d);
            }

            ViewBag.DeptList = ds;

            return View(obj.Emp.ToList());
        }

        public ActionResult EditEmp(int id)
        {
            List<SelectListItem> ds = new List<SelectListItem>();

            Employee empinfo = obj.Emp.Find(id);

            foreach (var d in obj.Dept)
            {
                if(d.DeptID == id)
                    ds.Add(new SelectListItem { Text = d.DeptName, Value = d.DeptID.ToString(), Selected=true });
                else
                    ds.Add(new SelectListItem { Text = d.DeptName, Value = d.DeptID.ToString() });
            }

            ViewBag.DeptList = ds;

            return View(empinfo);
        }

        [HttpPost]
        public ActionResult EditEmp(Employee e)
        {
            var empinfo = obj.Emp.Find(e.EmpID);

            empinfo.EmpName = e.EmpName;
            empinfo.Salary = e.Salary;
            empinfo.DeptNo = e.DeptNo;

            obj.SaveChanges();

            return View("DisplayEmps", obj.Emp.ToList());
        }



    }
}