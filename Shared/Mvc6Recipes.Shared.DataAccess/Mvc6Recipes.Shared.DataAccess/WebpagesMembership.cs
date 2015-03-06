// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // webpages_Membership
    public partial class WebpagesMembership
    {
        public int UserId { get; set; } // UserId (Primary key)
        public DateTime? CreateDate { get; set; } // CreateDate
        public string ConfirmationToken { get; set; } // ConfirmationToken
        public bool? IsConfirmed { get; set; } // IsConfirmed
        public DateTime? LastPasswordFailureDate { get; set; } // LastPasswordFailureDate
        public int PasswordFailuresSinceLastSuccess { get; set; } // PasswordFailuresSinceLastSuccess
        public string Password { get; set; } // Password
        public DateTime? PasswordChangedDate { get; set; } // PasswordChangedDate
        public string PasswordSalt { get; set; } // PasswordSalt
        public string PasswordVerificationToken { get; set; } // PasswordVerificationToken
        public DateTime? PasswordVerificationTokenExpirationDate { get; set; } // PasswordVerificationTokenExpirationDate

        public WebpagesMembership()
        {
            IsConfirmed = false;
            PasswordFailuresSinceLastSuccess = 0;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
