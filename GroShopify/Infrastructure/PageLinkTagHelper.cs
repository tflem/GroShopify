using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using GroShopify.Models.ViewModels;

namespace GroShopify.Infrastructure
{
    public class PageLinkTagHelper
    {
        [HtmlTargetElement("div", Attributes = "page-model")]
        public class PageLinkTagHelper : TagHelper 
        {
            private IUrlHelperFactory IUrlHelperFactory;

            public PageLinkTagHelper(IUrlHelperFactory helperFactory)
            {
                IUrlHelperFactory = helperFactory;
            }

            [ViewContext]
            [HtmlAttributeNotBound]
            public ViewContext ViewContext { get; set; }

            public PagingInfo PageModel { get; set; }

            public string PageAction { get; set; }

            public override void Process(TagHelperContext context,
                    TagHelperOutPut output) 
            {
                IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
                TagBuilder result = new TagBuilding("div");
                for (int i = 1; i <= PageModel.TotalPages; i++)
                {
                    TagBuilder tag = new TagBuilder("a");
                    tag.Attributes["href"] = urlHelper.Action(PageAction,
                       new { productPage = 1 });
                    tag.InnerHtml.Append(i.ToString());
                    result.InnerHtml.AppendHtml(tag);
                }
                output.Content.AppendHtml(result.InnerHtml);
            }
        }        
    }
}