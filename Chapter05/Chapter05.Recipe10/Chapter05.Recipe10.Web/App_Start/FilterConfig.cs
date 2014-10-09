using Chapter05.Recipe10.Web.Infrastructure.Filters;
using System.Web;
using System.Web.Mvc;

namespace Chapter05.Recipe10.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CultureSelectorFilterAttribute());
        }
    }
}
