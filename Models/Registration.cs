using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartShop.Models
{
    public class Registration
    {
        [Key]
        public int RegId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "This field is Required.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This field is Required.")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "DoB is Needed")]
        public string DoB { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "This field is Required.")]
        public string Gender { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "This field is Required.")]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "This field is Required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "User ID")]
        [Required(ErrorMessage = "This field is Required.")]
        public string UserId { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is Required.")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password Mismatch.")]
        public string ConfrimPassword { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Select one field.")]
        public string Category { get; set; }
    }
}