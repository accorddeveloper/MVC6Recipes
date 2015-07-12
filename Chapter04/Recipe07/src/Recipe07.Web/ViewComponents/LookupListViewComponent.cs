using System.Linq;
using Microsoft.AspNet.Mvc;
using Mvc6Recipes.Shared.DataAccess;
using Microsoft.AspNet.Mvc.Rendering;

namespace Recipe07.Web.ViewComponents
{
    public class LookupListViewComponent : ViewComponent
    {
        private readonly MoBContext db = new MoBContext();

        public IViewComponentResult Invoke()
        {
            var query = from a in db.GenreLookUps
                        select new SelectListItem { Text = a.GenreName, Value = a.GenreLookUpId.ToString() };

            return View(query.ToList());

        }
        
    }

    
}
