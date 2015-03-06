

namespace Mvc6Recipes.Shared.DataAccess.Repository
{
    public class QueryOptions
    {
        public int PageSize { get; set; }
        public bool UsePages { get; set; }
        public string SortColumnName { get; set; }
        public bool SortAscending { get; set; }

        public QueryOptions()
        {
            PageSize = 20;
            UsePages = true;
        }
    }
}
