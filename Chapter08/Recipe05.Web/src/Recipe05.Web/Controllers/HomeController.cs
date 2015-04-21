using Microsoft.AspNet.Mvc;
using Mvc6Recipes.Shared.DataAccess;
using Mvc6Recipes.Shared.DataAccess.Facade;
using Recipe05.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipe05.Web.Controllers
{

    public class HomeController : Controller
    {
        private IUnitOfWork _Uow;
        public HomeController(IUnitOfWork uow)
        {
            _Uow = uow;
        }

        [Route("/{Page?}/{SortExpression?}/{Genres?}")]
        public IActionResult Index(int? Page,
                                        string SortExpression,
                                        bool? Accending,
                                        string Genres
)
        {
            //Set default values for all optional  parameters
            int safePage = Page ?? 1;
            string safeSortExpression = string.IsNullOrEmpty(SortExpression) ? "CreateDate" : SortExpression;
            bool useDefaultSort = Accending.HasValue ? Accending.Value : true;

            int resultsFound = 0;
            var model = new CollaborationSpaceSearchResultModel();
            var filters = ParseGenres(Genres);
            var search = new CollaborationSpaceSearchParams { SortExpression = safeSortExpression,
                CurrentPageNumber = safePage,
                ItemsPerPage = 10 ,
                GenreFilter = filters
            };

            model.CollaborationSpaceSearchResults =
            _Uow.CollaborationSpaceRepository.GetActiveCollaborationSpaces(search,
                                             out resultsFound);

            model.NumberOfResults = resultsFound;
            model.GenreLookUpList =(IList<GenreLookUp>) _Uow.GenreLookUpRepository.Query();
            model.CurrentPage = safePage;
            model.ItemsPerPage = 10;
            model.SortExpression = safeSortExpression;
            

            // if a filter has been selected add to the model
            // so we can show what filter is selected in the view
            if (filters != null && filters.Count > 0)
            {
                model.GenreLookUpId = filters[0];
            }
            model.ResultsDescription = string.Format("Displaying records {0} - {1} of {2} sorted by {3}", 
                (safePage * 10), 
                (safePage * 10) + 10, 
                resultsFound, 
                safeSortExpression);
            return View("Index", model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_Uow != null)
                    _Uow.Dispose();
            }
            base.Dispose(disposing);
        }


        private List<int> ParseGenres(string genres)
        {
            if (string.IsNullOrEmpty(genres))
                return null;
            var genresSelecteed = genres.Split(new char[] { '|' });
            var outCollection = new List<int>();
            foreach (var item in genresSelecteed)
            {
                int outParam = 0;
                int.TryParse(item, out outParam);
                outCollection.Add(outParam);
            }
            // work around for bug in EF 7
            if (outCollection.Count == 1)
            {
                outCollection.Add(0);
            }
            return outCollection;
        }
    }

}
