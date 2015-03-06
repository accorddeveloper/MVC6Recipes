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
    // GenreLookUp
    public partial class GenreLookUp
    {
        public int GenreLookUpId { get; set; } // GenreLookUpId (Primary key)
        public string GenreName { get; set; } // GenreName
        public string Culture { get; set; } // Culture

        // Reverse navigation
        public virtual ICollection<BandGenre> BandGenres { get; set; } // BandGenre.FK_BandGenre_GenreLookUp
        public virtual ICollection<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; } // CollaborationSpaceGenre.FK_CollaborationSpaceGenre_GenreLookUp

        public GenreLookUp()
        {
            Culture = "en";
            BandGenres = new List<BandGenre>();
            CollaborationSpaceGenres = new List<CollaborationSpaceGenre>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
