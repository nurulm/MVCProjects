using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCViewModelApp.Models
{
    public class FSCollectionViewModel
    {
        public List<FacultyModel> Faculties { set; get; }

        public List<StudentModel> Students { set; get; }

    }
}