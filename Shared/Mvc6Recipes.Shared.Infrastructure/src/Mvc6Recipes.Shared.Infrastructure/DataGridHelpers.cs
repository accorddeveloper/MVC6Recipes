using Microsoft.AspNet.Mvc.Rendering;
using System.Text;
using Microsoft.AspNet.WebUtilities;

namespace Shared.Infrastructure.HtmlHelpers
{
    public static class DataGridHelpers
    {
        public static HtmlString CreateNumericPager(this IHtmlHelper helper,
                                               int totalNumResults,
                                               int itemsPerPage,
                                               int currentPage,
                                               string pagerCssClassName = "pagination", 
                                               string activeCssClassName = "active")
        {
            if (totalNumResults <= itemsPerPage)
            {
                //no pager needed
                return HtmlString.Empty;
            }
            else
            {
                int numberOfPages = totalNumResults / itemsPerPage;
                int maxNumberOfPagesShown = 20;
                bool showFirstAndLast = numberOfPages > maxNumberOfPagesShown;
                int startPage = getStartPage(numberOfPages, currentPage);
                int endPage = getEndPage(numberOfPages, currentPage, startPage);

                StringBuilder builder = new StringBuilder();
                builder.Append(string.Format(@"<ul class=""{0}"">",pagerCssClassName));
                if (showFirstAndLast && startPage > 1)
                {
                    builder.Append("<li>");
                    builder.Append(buildActionLink(helper, "...", 1));
                    builder.Append("</li>");
                }

                for (int i = startPage; i <= endPage; i++)
                {
                    string PageLinkText = i.ToString();
                    
                    if (i != currentPage)
                    {
                        builder.Append("<li>");
                        builder.Append(buildActionLink(helper, PageLinkText, i));
                    }
                    else
                    {
                        builder.Append(string.Format(@"<li class=""{0}"">", activeCssClassName));
                        builder.Append(string.Format(@"<a href=""#"">{0}</a>",i));
                    }
                    builder.Append(" </li>");

                }

                if (showFirstAndLast && (endPage != numberOfPages))
                {
                    builder.Append("<li>");
                    builder.Append(buildActionLink(helper, "...", numberOfPages));
                    builder.Append("</li>");
                }

                builder.Append("</ul>");
                var tagBuilder = new TagBuilder("div");
                tagBuilder.InnerHtml = builder.ToString();
                return tagBuilder.ToHtmlString(TagRenderMode.Normal);
            }
        }

        private static int getStartPage(int numberOfPages, int currentPage)
        {
            int minToDisplay = 1;
            if (currentPage > 10)
            {
                minToDisplay = currentPage - 9;
            }
            if (currentPage > (numberOfPages - 10) && (numberOfPages > 20))
            {
                minToDisplay = numberOfPages - 20;
            }
            return minToDisplay;
        }

        private static int getEndPage(int numberOfPages, int currentPage, int startPage)
        {
            int maxToDisplay = startPage + 19;
            if (maxToDisplay > numberOfPages)
            {
                maxToDisplay = maxToDisplay - (maxToDisplay - numberOfPages);
            }
            if ((currentPage > numberOfPages - 10) && (startPage != 1))
            {
                maxToDisplay = numberOfPages;
            }
            return maxToDisplay;
        }

        private static string buildActionLink(IHtmlHelper helper,
                                      string linkText,
                                      int pageParam)
        {
            if (helper.ViewContext.HttpContext.Request.QueryString.HasValue)
            {
                var queryString = QueryHelpers.ParseQuery(helper.ViewContext.HttpContext.Request.QueryString.Value);
                string[] sort, categoryId;
                queryString.TryGetValue("SortExpression", out sort);
                queryString.TryGetValue("CategoryId", out categoryId);

                return helper.ActionLink(linkText,
                               helper.ViewContext.RouteData.Values["action"].ToString(),
                               new
                               {
                                   SortExpression = sort,
                                   CategoryId = categoryId,
                                   Page = pageParam
                               }).ToString();
            }
            else
            {
                return helper.ActionLink(linkText,
                               helper.ViewContext.RouteData.Values["action"].ToString(),
                               new
                               {
                                   Page = pageParam
                               }).ToString();
            }
        }
    }



}
