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
    // CollaborationSpaceFile
    public partial class CollaborationSpaceFile
    {
        public int CollaborationSpaceFileId { get; set; } // CollaborationSpaceFileId (Primary key)
        public int CollaborationSpaceId { get; set; } // CollaborationSpaceId
        public int MediaId { get; set; } // MediaId
        public string Description { get; set; } // Description
        public int LikeCount { get; set; } // LikeCount

        // Reverse navigation
        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComments { get; set; } // CollaborationSpaceComment.FK_CollaborationSpaceComment_ToTable

        // Foreign keys
        public virtual CollaborationSpace CollaborationSpace { get; set; } // FK_CollaborationSpaceFile_CollaborationSpace
        public virtual Medium Medium { get; set; } // FK_CollaborationSpaceFile_Media

        public CollaborationSpaceFile()
        {
            LikeCount = 0;
            CollaborationSpaceComments = new List<CollaborationSpaceComment>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
