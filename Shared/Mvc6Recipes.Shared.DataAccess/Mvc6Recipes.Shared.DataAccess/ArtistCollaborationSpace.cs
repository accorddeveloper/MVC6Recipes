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
    // ArtistCollaborationSpaces
    public partial class ArtistCollaborationSpace
    {
        public int ArtistCollaborationSpaceId { get; set; } // ArtistCollaborationSpaceId (Primary key)
        public int ArtistId { get; set; } // ArtistId
        public int CollaborationSpaceId { get; set; } // CollaborationSpaceId
        public bool IsCreator { get; set; } // IsCreator
        public DateTime FirstContributionDate { get; set; } // FirstContributionDate
        public DateTime LastContributionDate { get; set; } // LastContributionDate
        public string Note { get; set; } // Note

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_ArtistCollaborationSpaces_ToTable
        public virtual CollaborationSpace CollaborationSpace { get; set; } // FK_ArtistCollaborationSpaces_ToTable_1

        public ArtistCollaborationSpace()
        {
            IsCreator = false;
            FirstContributionDate = System.DateTime.Now;
            LastContributionDate = System.DateTime.Now;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
