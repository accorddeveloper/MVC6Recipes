using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mvc6Recipes.Shared.DataAccess.Util;

namespace Mvc6Recipes.Shared.DataAccess
{

    [MetadataType(typeof(CollaborationSpaceMetaData))]
    public partial class CollaborationSpace { }
    public class CollaborationSpaceMetaData
    {
        [Required]
        public object Title { get; set; }

//        public string AvatarUrlSample
//        {
//            get
//            {
//#if DEBUG
//                return DebugDataSubstitute.GetRandomImagePath();
//#else
//                return AvatarUrl;
//#endif
//            }
//        }
    }



}
