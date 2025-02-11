using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace Library.Web.UI.TagHelpers;

[HtmlTargetElement("list-pager")]
public class PageingTagHelper : TagHelper
{
    [HtmlAttributeName("page-size")]
    public int PageSize { get; set; }

    [HtmlAttributeName("page-count")]
    public int PageCount { get; set; }



    [HtmlAttributeName("current-page")]
    public int CurrentPage { get; set; }

    [HtmlAttributeName("page-name")]
    public string  PageName { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "section";
        var sb = new StringBuilder();
        sb.Append("<ul class='pagination'>");

        for (int i = 1; i <= PageCount; i++)
        {
            string activeClass = (i == CurrentPage) ? "page-item active" :
                    "page-item";
            string url = $"/{PageName}/index?page={i}";
            sb.AppendFormat("<li class='{0}'>",activeClass);
            sb.AppendFormat("<a class='page-link' href='{0}' >{1}</a>",url,i);
            sb.Append("</li>");
        }
        sb.Append("</ul>");
        output.Content.SetHtmlContent(sb.ToString());

    }
}
