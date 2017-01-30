using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCJTableApp.Models;

namespace MVCJTableApp.Controllers
{
    public class DemoController : Controller
    {
        MVCEntities obj = new MVCEntities(); //Create DB Context Object
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudents(int jtstartindex, int jtpagesize, string jtsorting)
        {
            var res = from s in obj.Students select s;

            switch(jtsorting)
            {
                case "StudID ASC":
                    res = res.OrderBy(s => s.StudID);
                    break;
                case "studid DESC":
                    res = res.OrderByDescending(s => s.StudID);
                    break;
                case "studname ASC":
                    res = res.OrderBy(s => s.StudName);
                    break;
                case "studname DESC":
                    res = res.OrderByDescending(s => s.StudName);
                    break;
            } //Closing Switch

            int c = res.Count(); //Returns no of recs

            res = res.Skip(jtstartindex);
            res = res.Take(jtpagesize);

            return Json(new { Result = "OK", Records = res, totalrecordcount = c });
        }

        public JsonResult AddStudent(Student s)
        {
            try
            {
                obj.Students.Add(s);

                obj.SaveChanges();
                return Json(new { Result="OK", Record=s  });
            }catch(Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message+ "Student ID Already Exists" });

            }
        }

        public JsonResult UpdateStudent (Student s)
        {
            try
            {
                obj.Entry(s).State = System.Data.Entity.EntityState.Modified;
                obj.SaveChanges();
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
             }
        }

        public JsonResult DeleteStudent (Student s)
        {
            obj.Entry(s).State = System.Data.Entity.EntityState.Deleted;

            obj.SaveChanges();

            return Json(new { Result = "OK" });
        }
    }
}