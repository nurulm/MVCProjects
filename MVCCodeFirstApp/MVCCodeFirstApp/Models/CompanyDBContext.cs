using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCodeFirstApp.Models
{
    public class CompanyDBContext : DbContext
    {
        public virtual DbSet<Department> Dept { set; get; }

        public virtual DbSet<Employee> Emp { set; get; }
    }
}