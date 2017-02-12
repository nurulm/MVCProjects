using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCNETTagHelpersApp.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please Enter User Name")]
        public string UserName { get; set; }

        public string Password { get; set; }

        [Range(25, 40, ErrorMessage = "Invalid Age")]
        public int Age { get; set; }

        public string SkillSet { get; set; }

        public string Country { get; set; }

        public bool TermsAccepted { get; set; }
    }
}
