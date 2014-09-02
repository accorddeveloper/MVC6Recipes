using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Chapter05.Recipe10.Resources.Web.Models;


namespace Chapter05.Recipe10.Web.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "ExternalLoginConfirmationEmail", ResourceType = typeof(AccountViewModelResource))]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required(ErrorMessageResourceName = "VerifyCodeViewModelCodeRequiredError" ,ErrorMessageResourceType = typeof(AccountViewModelResource))]
        [Display(Name = "VerifyCodeViewModelCode", ResourceType = typeof(AccountViewModelResource))]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "VerifyCodeViewModeRemember", ResourceType = typeof(AccountViewModelResource))]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "ForgotViewModelEmail", ResourceType = typeof(AccountViewModelResource))]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "LoginViewModelEmail", ResourceType = typeof(AccountViewModelResource))]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "LoginViewModelPassword", ResourceType = typeof(AccountViewModelResource))]
        public string Password { get; set; }

        [Display(Name = "LoginViewModelRemember", ResourceType = typeof(AccountViewModelResource))]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessageResourceName = "RegisterViewModelEmailRequired", ErrorMessageResourceType = typeof(AccountViewModelResource))]
        [EmailAddress]
        [Display(Name = "RegisterViewModelEmail", ResourceType = typeof(AccountViewModelResource))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "RegisterViewModelPasswordRequired", ErrorMessageResourceType = typeof(AccountViewModelResource))]
        [StringLength(100, ErrorMessageResourceName = "RegisterViewModelPasswordStringLenError", ErrorMessageResourceType = typeof(AccountViewModelResource), MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "RegisterViewModelPassword", ResourceType = typeof(AccountViewModelResource))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "RegisterViewModelPasswordConfirm", ResourceType = typeof(AccountViewModelResource))]
        [Compare("Password", ErrorMessageResourceName = "RegisterViewModelPasswordCompareError", ErrorMessageResourceType = typeof(AccountViewModelResource))]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
