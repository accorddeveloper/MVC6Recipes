using System;
using Microsoft.AspNet.Mvc.Rendering;
using System.Collections;
using System.Text;

namespace Shared.Infrastructure.HtmlHelpers
{
    public static class DataListHelpers
    {
        // create a delegate with same signature as HTML.Partial to avoid coupling with 
        // view context in order to simplify unit testing
        public delegate HtmlString GetStringFromAction(string viewName, object model);


        public static HtmlString RenderTemplateAsColumns(this IHtmlHelper helper,
                ICollection items,
                string partialViewName,
                int numberOfColumns)
        {
            return RenderTemplateAsColumns(helper,
                                           items,
                                           partialViewName,
                                           numberOfColumns,
                                           helper.Partial);
        }


        public static HtmlString RenderTemplateAsColumns(this IHtmlHelper helper,
                ICollection items,
                string partialViewName,
                int numberOfColumns,
                GetStringFromAction getStringMethod
              )
        {
            //validate input
            if (numberOfColumns < 1)
            {
                throw new ArgumentOutOfRangeException("numberOfColumns");
            }
            if (items == null)
            {
                throw new ArgumentNullException("items");
            }

            if (items == null || items.Count > 0)
            {

                StringBuilder builder = new StringBuilder();

                int columnsInRow = 1;
                int rowsDone = 0;
                int numberOfItemsDone = 0;
                int numberOfExtraColumnsInLastRow;

                //calculate the needed table structure
                int numberOfRows = items.Count / numberOfColumns;

                //Create the opening table tag
                builder.Append("<table>");

                //Create the rows and columns
                foreach (var item in items)
                {
                    if (columnsInRow == 1)
                    {
                        builder.Append("<tr>");
                    }

                    builder.Append("<td>");
                    builder.Append(getStringMethod(partialViewName, item));
                    builder.Append("</td>");
                    bool isLastItem = (items.Count == numberOfItemsDone + 1);

                    if ((columnsInRow == numberOfColumns) || isLastItem)
                    {
                        if (isLastItem)
                        {
                            numberOfExtraColumnsInLastRow = numberOfColumns - columnsInRow;
                            builder.Append(RenderExtraColumns(numberOfExtraColumnsInLastRow));
                        }
                        builder.Append("</tr>");
                        columnsInRow = 1;
                        rowsDone++;
                    }
                    else
                    {
                        columnsInRow++;
                    }

                    numberOfItemsDone++;
                }

                // create the closing table tag
                builder.Append("</table>");

                // convert output into HTMLString
                var tagBuilder = new TagBuilder("table");
                tagBuilder.InnerHtml = builder.ToString();
                return tagBuilder.ToHtmlString(TagRenderMode.Normal);

            }

            return HtmlString.Empty;
        }


        private static string RenderExtraColumns(int numberOfExtraColumnsInLastRow)
        {
            if (numberOfExtraColumnsInLastRow > 0)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < numberOfExtraColumnsInLastRow; i++)
                {
                    builder.Append("<td></td>");
                }
                return builder.ToString();
            }
            return string.Empty;

        }


    }
}