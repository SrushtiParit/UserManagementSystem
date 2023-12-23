using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Users
    {
        public int RowNum { get; set; }
        [Required(ErrorMessage = "Please enter Your Name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter Your Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter Your Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter Your Email ID")]
        [RegularExpression(@"^[\w\.-]+@[\w\.-]+\.\w+$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
    }
}