using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Recipe05.Web.Models;
using Microsoft.AspNet.Mvc.Rendering;

namespace Recipe05.Web.Controllers
{
    public class HomeController : Controller
    {
        private List<SelectListItem> _items = new List<SelectListItem>
            {
                new SelectListItem { Value="", Text="Please Select a Brand"},
                new SelectListItem { Value="1", Text="Gibson" },
                new SelectListItem { Value="2", Text="Charvel" },
                new SelectListItem { Value="3", Text="Ibenez" },
                new SelectListItem { Value="4", Text="Jackson"  }
            };
        public IActionResult Index()
        {
            var model = new GuitarBrandViewModel();
            model.Brands = _items;


            return View(model);
        }

        [HttpPost]
        public IActionResult Index(GuitarBrandViewModel model)
        {
            model.Brands = _items;
            if (model.SelectedBrandId != 0)
            {
                model.SelectedBrand = (from b in _items
                                       where b.Value == model.SelectedBrandId.ToString()
                                       select new GuitarBrand {
                                           GuitarBrandId = int.Parse(b.Value),
                                           Name = b.Text }).FirstOrDefault();

            }
            
            return View(model);
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
