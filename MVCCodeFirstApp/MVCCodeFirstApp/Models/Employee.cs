using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCodeFirstApp.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpID { get; set; }

        public string EmpName { get; set; }

        public int Salary { get; set; }

        public int DeptNo { get; set; }

        [ForeignKey("DeptNo")]
        public Department Dinfo { set; get; }
    }
}