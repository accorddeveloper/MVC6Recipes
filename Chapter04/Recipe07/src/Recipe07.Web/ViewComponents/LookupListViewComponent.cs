using System.Linq;
using Microsoft.AspNet.Mvc;
using Mvc6Recipes.Shared.DataAccess;
using Microsoft.AspNet.Mvc.Rendering;

namespace Recipe07.Web.ViewComponents
{
    public class LookupListViewComponent : ViewComponent
    {
        private readonly MoBContext _db;
        public LookupListViewComponent(MoBContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var query = from a in _db.GenreLookUps
                        select new SelectListItem { Text = a.GenreName, Value = a.GenreLookUpId.ToString() };

            return View(query.ToList());

        }
        
    }

    
}
