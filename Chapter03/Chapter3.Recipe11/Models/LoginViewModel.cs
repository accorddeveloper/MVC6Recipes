using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chapter3.Recipe11.Model
{
    /// <summary>
    /// Summary description for LoginViewModel
    /// </summary>
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public bool? RememberMeAlso { get; set; }
    }
}