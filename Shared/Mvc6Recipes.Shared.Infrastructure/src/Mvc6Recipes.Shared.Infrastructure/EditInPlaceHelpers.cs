using System;
using System.Linq.Expressions;
using Microsoft.AspNet.Mvc.Rendering;

namespace Shared.Infrastructure.HtmlHelpers
{
    public static class EditInPlaceHelpers
    {
        // returns the default editor for the property   when isSelected
        // is true
        public static HtmlString DataGridEditorFor<TModel, TProperty>
                             (this IHtmlHelper<TModel> helper,
                              bool isSelected,
                              Expression<Func<TModel, TProperty>> expression)
                              where TModel : class
        {
            if (isSelected)
            {
                return new HtmlString(helper.EditorFor(expression).ToString());
            }
            else
            {
                return new HtmlString(helper.DisplayFor(expression).ToString());
            }
        }

        // returns a text box for the property when isSelected
        // is true
        public static HtmlString DataGridTextBoxFor<TModel, TProperty>
                            (this IHtmlHelper<TModel> helper,
                             bool isSelected,
                             Expression<Func<TModel, TProperty>> expression)
                             where TModel : class
        {
            if (isSelected)
            {
                return new HtmlString(helper.TextBoxFor(expression).ToString());
            }
            else
            {
                return new HtmlString(helper.DisplayFor(expression).ToString());
            }
        }

        // returns the default editor for the property when isSelected
        // is true  
        public static HtmlString DataGridTextAreaFor<TModel, TProperty>
                             (this IHtmlHelper<TModel> helper,
                             bool isSelected,
                             Expression<Func<TModel, TProperty>> expression)
                             where TModel : class
        {
            if (isSelected)
            {
                return new HtmlString(helper.TextAreaFor(expression).ToString());
            }
            else
            {
                return new HtmlString(helper.DisplayFor(expression).ToString());
            }
        }

    }


}