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
    // ArtistBlock
    public partial class ArtistBlock
    {
        public int ArtistBlockId { get; set; } // ArtistBlockId (Primary key)
        public int ArtistId { get; set; } // ArtistId
        public int BlockedArtistId { get; set; } // BlockedArtistId
        public DateTime CreateDate { get; set; } // CreateDate
        public bool ReportAsSpammer { get; set; } // ReportAsSpammer

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_ArtistBlock_Artist

        public ArtistBlock()
        {
            CreateDate = System.DateTime.Now;
            ReportAsSpammer = false;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
