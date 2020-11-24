using System;
using System.ComponentModel.DataAnnotations;
namespace SoftwareTestingCore.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

        [Display(Name = "Subscribe")]
        public bool WantsEmails { get; set; }
    }

    public class UserViewModel {

        public User user { get; set; }

        public int notification { get; set; }
    }
}
