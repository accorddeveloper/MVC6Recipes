using System;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Routing;
using Microsoft.AspNet.Mvc.Rendering;

namespace Shared.Infrastructure.HtmlHelpers
{
    /// <summary>
    /// This class is used in Chapter 09 Recipe 04
    /// </summary>
    public static class WizardHelpers
    {
        public static HtmlString WizardBackButton(this IHtmlHelper helper,
                                             string actionName,
                                             string controller)
        {
            if (validateAC(actionName, controller))
            {
                return createPostBackLink(helper, "Back", actionName, controller);
            }
            return HtmlString.Empty;
        }

        public static HtmlString WizardNextButton(this IHtmlHelper helper,
                                              string actionName,
                                              string controller)
        {
            if (validateAC(actionName, controller))
            {
                return createPostBackLink(helper, "Next", actionName, controller);
            }
            return HtmlString.Empty;
        }

        public static HtmlString WizardFinishButton(this IHtmlHelper helper,
                                                string actionName,
                                                string controller)
        {
            if (validateAC(actionName, controller))
            {
                return createPostBackLink(helper, "Finish", actionName, controller);
            }
            return HtmlString.Empty;
        }

        public static HtmlString WizardSideButton(this IHtmlHelper helper,
                                              string text,
                                              string actionName,
                                              string controller)
        {
            if (validateAC(actionName, controller))
            {
                return createPostBackLink(helper, text, actionName, controller);
            }
            return HtmlString.Empty;
        }

        private static HtmlString createPostBackLink(IHtmlHelper helper,
                                              string text,
                                              string actionName,
                                              string controller)
        {

            var vpc = new VirtualPathContext(
                helper.ViewContext.HttpContext,
                null,
                (new RouteValueDictionary {
                      { "controller", controller },
                      { "action", actionName } })

                      );
            var actionUrl = helper.ViewContext.RouteData.Routers[0].GetVirtualPath(vpc);

            return new HtmlString(String.Format(@"<a href=""#"" class=""btn btn-default"" onclick=""wizard.WizardSubmit('{0}')"">{1}</a>",
                  actionUrl, text));
        }

        private static bool validateAC(string a, string c)
        {
            if (!String.IsNullOrEmpty(a) && !String.IsNullOrEmpty(c))
            {
                return true;
            }
            return false;
        }

    }
}