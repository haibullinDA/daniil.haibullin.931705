using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.App_code
{
    public static class HTMLHelper
    {
        public static HtmlString CreateForm(this IHtmlHelper html)
        {
            string result = "<input name=\"input1\" />" +
                "<select name=\"operation\">" +
                "<option>+</option>" +
                "<option>-</option>" +
                "<option>*</option>" +
                "<option>/</option>" +
                "</select>" +
                "<input name=\"input2\" />" +
                "<input type=\"submit\" />";
            return new HtmlString(result);
        }
    }
}
