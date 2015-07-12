using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System.Threading.Tasks;

namespace Recipe09.TagHelpers
{
    [TargetElement("a", Attributes = GlyphIconName)]
    public class GlyphiconLinkTagHelper : TagHelper
    {
        private const string GlyphIconName = "asp-GlyphIcon";

        private const string EditIcon = "edit";
        private const string DeleteIcon = "trash";

        public GlyphiconLinkTagHelper() : base()
        {
            
        }
        [HtmlAttributeName(GlyphIconName)]
        public string IconName { get; set; }

        private string getIconName()
        {
            if(!string.IsNullOrEmpty(IconName) && IconName.ToLowerInvariant() == "edit")
            {
                return EditIcon;
            }
            return DeleteIcon;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var content = await context.GetChildContentAsync();
            var iconHTML = string.Format(" <span class='glyphicon glyphicon-{0}'> </span>",getIconName());
            if (content.IsEmpty || content.IsWhiteSpace)
            {
                output.Content.SetContent(iconHTML);
            }
            else
            {
                output.Content.SetContent(content.Append(iconHTML));
            }
            
        }
    }
}
