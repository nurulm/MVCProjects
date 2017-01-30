using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHTMLHelperApp.Models
{
    public class CustomerModel
    {

        public string CustomerName { set; get; }

        public string RoomType { set; get; }

        public string Eminities { set; get; }

        public Gender CustomerGender { set; get; }
    }

    public enum Gender{ Male, Female  }
}