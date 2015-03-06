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
    // ArtistProfile
    public partial class ArtistProfile
    {
        public int ArtistId { get; set; } // ArtistId (Primary key)
        public string Bio { get; set; } // Bio
        public string MusicalInfluences { get; set; } // MusicalInfluences
        public string ProfileTemplateName { get; set; } // ProfileTemplateName
        public string FirstName { get; set; } // FirstName
        public string LastName { get; set; } // LastName

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_ArtistProfile_Artist

        public ArtistProfile()
        {
            ProfileTemplateName = "basic";
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
