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
    // webpages_OAuthMembership
    public partial class WebpagesOAuthMembership
    {
        public string Provider { get; set; } // Provider (Primary key)
        public string ProviderUserId { get; set; } // ProviderUserId (Primary key)
        public int UserId { get; set; } // UserId
    }

}
