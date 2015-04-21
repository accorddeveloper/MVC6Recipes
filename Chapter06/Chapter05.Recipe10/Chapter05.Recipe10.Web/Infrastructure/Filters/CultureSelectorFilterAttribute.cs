using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace Chapter05.Recipe10.Web.Infrastructure.Filters
{
    public class CultureSelectorFilterAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
           
        }

        private const string DefaultLocal = "en-US";
        private const string LocalCookie = "localeCookie";

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

            // check for the existence of route parameter,
            var locale = filterContext.RouteData.Values["culture"] as string;
            if (!string.IsNullOrEmpty(locale))
            {
                // route parameter found
                SetCultures(locale);
            }
            else
            {
                // if no route parameter exists and culture sent in header
                // redirect to route that includes culture route parama
                var httpCulture = (filterContext.HttpContext.Request.UserLanguages == null ||
                                   filterContext.HttpContext.Request.UserLanguages.Length < 1)
                    ? string.Empty
                    : filterContext.HttpContext.Request.UserLanguages[0];

                // no culture info sent from browser
                if (httpCulture == null) return;

                //matches the default culture return
                if (httpCulture.StartsWith(DefaultLocal)) return;

                // add the route data to the route value dictionary and then redirect
                filterContext.RouteData.Values.Add("culture", httpCulture);
                filterContext.Result = new RedirectToRouteResult( filterContext.RouteData.Values);
            }


        }
        private static void SetCultures(string locale)
        {
            var culture = new CultureInfo(locale);
            // used to set dates, number and currency formats to the correct culture
            Thread.CurrentThread.CurrentCulture = culture;
            // used to select correct resource file
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}