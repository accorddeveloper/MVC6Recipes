using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc6Recipes.Shared.DataAccess.Repository
{
    public class CollaborationSpaceQueryOptions : QueryOptions
    {
        public ProjectStatus StatusFilter { get; set; }
        public ProjectCopyrightModel CopyrightFilter { get; set; }
        public string ProjectName { get; set; }
        public int ArtistId { get; set; }
        public int BandId { get; set; }
        public bool PublicOnly { get; set; }
        public bool AllowsPublicContributors { get; set; }


    }
}
