using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eShop.Models
{
    public class UserViewModel : IUser
    {
        public int UserId { get; set; }
        public int UserRole { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserPassword { get; set; }
        [Required]
        [Compare("UserPassword",ErrorMessage = "Passwords Did Not Match")]
        public string ConfirmPassword { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Please Enter a Valid Password")]
        public string UserEmail { get; set; }

        public string Preppend { get; set; }

        public string Append { get; set; }

        public byte[] Hash { get; set; }

        public bool ResetPassword { get; set; }

        public bool ForgotPassword { get; set; }
    }
}