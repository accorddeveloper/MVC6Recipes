using Mvc6Recipes.Shared.DataAccess;
using System.Collections.Generic;

namespace Recipe01.Web.Models
{
    public class ArtistMasterDetailsModel
    {
        public Artist SelectedArtist { get; set; }
        public int SelectedArtistId { get; set; }

        public List<Artist> ArtistList { get; set; }

    }
}