using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCViewModelApp.Models;

namespace MVCViewModelApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            FacultyModel FModel = new FacultyModel() { FacultyID = "1000", FacultyName = "Raju", FaculyAddress = "SR Nagar" };
            StudentModel SModel = new StudentModel() { StudentID = "2000", StudentName = "Kiran", StudentClass = ".NET" };

            FSViewModel FSObj = new FSViewModel();

            FSObj.FacultyInfo = FModel;
            FSObj.StudentInfo = SModel;

           
            return View(FSObj);

        }

        public ActionResult Index1()
        {
            List<FacultyModel> FModel = new List<FacultyModel>();
            List<StudentModel> SModel = new List<StudentModel>();

            FModel.Add(new FacultyModel() {FacultyID="1000", FacultyName="Raju", FaculyAddress="SR Nagar"});
            FModel.Add(new FacultyModel() { FacultyID = "1001", FacultyName = "Ravi", FaculyAddress = "Ameerpet" });
            FModel.Add(new FacultyModel() { FacultyID = "1002", FacultyName = "Ramesh", FaculyAddress = "Ameerpet" });

            SModel.Add(new StudentModel() { StudentID = "2000", StudentName = "Kavi", StudentClass = ".NET" });
            SModel.Add(new StudentModel() { StudentID = "2001", StudentName = "Ameer", StudentClass = "Java" });
            SModel.Add(new StudentModel() { StudentID = "2002", StudentName = "Rida", StudentClass = "C++" });

            FSCollectionViewModel FsDetails = new FSCollectionViewModel();

            FsDetails.Faculties = FModel;
            FsDetails.Students = SModel;

            return View(FsDetails);
        }
    }
}