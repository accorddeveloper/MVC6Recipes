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
    // ArtistFavorites
    public partial class ArtistFavorite
    {
        public int ArtistFavoriteId { get; set; } // ArtistFavoriteId (Primary key)
        public int ArtistId { get; set; } // ArtistId
        public string Title { get; set; } // Title
        public int? ItemId { get; set; } // ItemId
        public int Category { get; set; } // Category
        public DateTime CreateDate { get; set; } // CreateDate

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_ArtistFavorites_Artist

        public ArtistFavorite()
        {
            CreateDate = System.DateTime.Now;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
