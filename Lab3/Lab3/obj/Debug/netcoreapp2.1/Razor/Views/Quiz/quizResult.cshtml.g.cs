#pragma checksum "C:\Users\danil\Downloads\Lab3-20200606T130529Z-001\Lab3\Lab3\Views\Quiz\quizResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a8a191173a2e5191cdb9e6079820ce2df11ed25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_quizResult), @"mvc.1.0.view", @"/Views/Quiz/quizResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Quiz/quizResult.cshtml", typeof(AspNetCore.Views_Quiz_quizResult))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\danil\Downloads\Lab3-20200606T130529Z-001\Lab3\Lab3\Views\_ViewImports.cshtml"
using Lab3;

#line default
#line hidden
#line 2 "C:\Users\danil\Downloads\Lab3-20200606T130529Z-001\Lab3\Lab3\Views\_ViewImports.cshtml"
using Lab3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8a191173a2e5191cdb9e6079820ce2df11ed25", @"/Views/Quiz/quizResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d9fce3dfd861de0f45d4b1a671e8fff8818d09", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_quizResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\danil\Downloads\Lab3-20200606T130529Z-001\Lab3\Lab3\Views\Quiz\quizResult.cshtml"
  
    ViewData["Title"] = "quizResult";
    int number = 1;
    if (ViewBag.ListResult.Count == 0) { ViewBag.ListResult.Add("Yay"); }

#line default
#line hidden
            BeginContext(144, 27, true);
            WriteLiteral("\r\n<h2>QuizResult</h2>\r\n<h2>");
            EndContext();
            BeginContext(172, 9, false);
#line 9 "C:\Users\danil\Downloads\Lab3-20200606T130529Z-001\Lab3\Lab3\Views\Quiz\quizResult.cshtml"
Write(ViewBag.C);

#line default
#line hidden
            EndContext();
            BeginContext(181, 25, true);
            WriteLiteral("</h2>\r\n<h3>Right answers ");
            EndContext();
            BeginContext(207, 25, false);
#line 10 "C:\Users\danil\Downloads\Lab3-20200606T130529Z-001\Lab3\Lab3\Views\Quiz\quizResult.cshtml"
             Write(ViewBag.RightAnswersCount);

#line default
#line hidden
            EndContext();
            BeginContext(232, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(237, 20, false);
#line 10 "C:\Users\danil\Downloads\Lab3-20200606T130529Z-001\Lab3\Lab3\Views\Quiz\quizResult.cshtml"
                                           Write(ViewBag.AnswersCount);

#line default
#line hidden
            EndContext();
            BeginContext(257, 28, true);
            WriteLiteral("</h3>\r\n\r\n<h2>Answers:</h2>\r\n");
            EndContext();
#line 13 "C:\Users\danil\Downloads\Lab3-20200606T130529Z-001\Lab3\Lab3\Views\Quiz\quizResult.cshtml"
 foreach (string result in ViewBag.ListResult)
{

#line default
#line hidden
            BeginContext(336, 8, true);
            WriteLiteral("    <h3>");
            EndContext();
            BeginContext(346, 8, false);
#line 15 "C:\Users\danil\Downloads\Lab3-20200606T130529Z-001\Lab3\Lab3\Views\Quiz\quizResult.cshtml"
    Write(number++);

#line default
#line hidden
            EndContext();
            BeginContext(355, 2, true);
            WriteLiteral(". ");
            EndContext();
            BeginContext(358, 6, false);
#line 15 "C:\Users\danil\Downloads\Lab3-20200606T130529Z-001\Lab3\Lab3\Views\Quiz\quizResult.cshtml"
                Write(result);

#line default
#line hidden
            EndContext();
            BeginContext(364, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 16 "C:\Users\danil\Downloads\Lab3-20200606T130529Z-001\Lab3\Lab3\Views\Quiz\quizResult.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
