using System.Collections.Generic;
using Microsoft.AspNet.Mvc.Rendering;

namespace Recipe05.Web.Models
{
    public class GuitarBrandViewModel
    {
        public List<SelectListItem> Brands { get; set; }
        public int SelectedBrandId { get; set; }

        public GuitarBrand SelectedBrand { get; set; }
    }
}
