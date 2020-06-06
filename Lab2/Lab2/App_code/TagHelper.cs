using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Lab2.App_code
{
    [HtmlTargetElement(Attributes ="Add")]
    public class OperationAddTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "option";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent("+");
        }
    }
    [HtmlTargetElement(Attributes = "Sub")]
    public class OperationSubTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "option";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent("-");
        }
    }
    [HtmlTargetElement(Attributes = "Mult")]
    public class OperationMultTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "option";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent("*");
        }
    }
    [HtmlTargetElement(Attributes = "Div")]
    public class OperationDivTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "option";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent("/");
        }
    }
}
