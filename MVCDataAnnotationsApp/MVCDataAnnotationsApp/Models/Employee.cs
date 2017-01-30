using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCDataAnnotationsApp.Models
{
    public class Employee
    {
        [Display (Name="Employee Number")]
        [Required(ErrorMessage ="Enter Employee Number")]
        public string EmployeeID { get; set; }


        [Display(Name ="Employee Name")]
        [Required(ErrorMessage ="Please Enter Name")]
        [StringLength(10, MinimumLength= 3)]
        public string EmployeeName { set; get; }


        [Display(Name ="Employee Address")]
        public string EmployeeAddress { set; get; }
    }
}