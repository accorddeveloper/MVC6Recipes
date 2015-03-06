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
    // AlertSubscription
    public partial class AlertSubscription
    {
        public int AlertSubscriptionId { get; set; } // AlertSubscriptionId (Primary key)
        public int ArtistId { get; set; } // ArtistId
        public string Tags { get; set; } // Tags

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_AlertSubscription_Artist
    }

}
