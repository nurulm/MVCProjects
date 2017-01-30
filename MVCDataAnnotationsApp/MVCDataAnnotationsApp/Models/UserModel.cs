using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MVCDataAnnotationsApp;


namespace MVCDataAnnotationsApp.Models
{
    public class UserModel
    {
       
        [Display(Name ="User Name")]
        [Required(ErrorMessage="Enter Name")]
        [RegularExpression("[A-Za-z\\s.]{1-20}",ErrorMessage ="Not a Valid User Name")]
        public string UserName { set; get; }


        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Enter Password")]
        public string Password { set; get; }


        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter Confirm Password")]
        [Compare("Password", ErrorMessage ="Passwords must be same")]
        public string ConfirmPassword { set; get; }


        [Display(Name ="Address")]
        [Required(ErrorMessage ="Enter Address")]
        [DataType(DataType.MultilineText)]
        public string Address { set; get; }


        [Display(Name ="Age")]
        [Required(ErrorMessage ="Enter Age")]
        [DataType(DataType.MultilineText)]
        [Range(30,45,ErrorMessage ="Invalid Date")]
        public int Age { set; get; }


        [Display(Name ="Email ID")]
        [Required(ErrorMessage ="Enter Email Id")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress] //Data Annotations extensions attribute
        public string EmailID { set; get; }


        [Display(Name ="Mobile Number")]
        [Required(ErrorMessage = "Enter Mobile Number")]
        [RegularExpression("\\d{10}")]
        public string Mobile { set; get; }


        [Display(Name ="Enter Even Number")]
        [System.Web.Mvc.Remote("ValidateEven","Demo", ErrorMessage ="Enter Even Number")]
        public int EvenNumber { set; get; }
    }
}