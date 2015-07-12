﻿using System.Collections.Generic;
using Microsoft.AspNet.Mvc.Rendering;

namespace Recipe05.Web.Models
{
    public class GuitarBrandViewModel
    {
        public List<SelectListItem> Brands { get; set; }
        public int SelectedBrandId { get; set; }

        public GuitarBrand SelectedBrand { get; set; }
    }

    public class GuitarBrand
    {
        public int GuitarBrandId { get; set; }
        public string Name { get; set; }
    }
}
