using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCADONETSample1.Models
{
    public class CustomerModel
    {
        
        [Display(Name="Account Number")]
        public int AcctNo { get; set; }

        [Display(Name = "Account Holder Name")]
        public string AcctHolderName { get; set; }

        [Display(Name ="Account Balance")]
        public int AcctBalance { get; set; }
    }
}