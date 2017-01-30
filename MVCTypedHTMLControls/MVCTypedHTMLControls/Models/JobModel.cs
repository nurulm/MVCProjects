using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTypedHTMLControls.Models
{
    public class JobModel
    {
        public string UserName { set; get; }

        public string Password { set; get; }

        public string Gender { set; get; }

        public string Country { set; get; }

        public string[] SkillSet { set; get; }

        public bool TermsAccepted { set; get; }

    }
}