#pragma checksum "C:\Users\danil\Downloads\Lab2-20200606T083631Z-001\Lab2\Lab2\Views\Calc\ModelBindingSeparateModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "660e2f6560ce01d36160d6cf11265449e8a38a9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_ModelBindingSeparateModel), @"mvc.1.0.view", @"/Views/Calc/ModelBindingSeparateModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calc/ModelBindingSeparateModel.cshtml", typeof(AspNetCore.Views_Calc_ModelBindingSeparateModel))]
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
#line 1 "C:\Users\danil\Downloads\Lab2-20200606T083631Z-001\Lab2\Lab2\Views\_ViewImports.cshtml"
using Lab2;

#line default
#line hidden
#line 2 "C:\Users\danil\Downloads\Lab2-20200606T083631Z-001\Lab2\Lab2\Views\_ViewImports.cshtml"
using Lab2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660e2f6560ce01d36160d6cf11265449e8a38a9c", @"/Views/Calc/ModelBindingSeparateModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd9d6898af3ee645766c02769f00bd7edd74cd52", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_ModelBindingSeparateModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Calc/Count4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Lab2.App_code.OperationAddTagHelper __Lab2_App_code_OperationAddTagHelper;
        private global::Lab2.App_code.OperationSubTagHelper __Lab2_App_code_OperationSubTagHelper;
        private global::Lab2.App_code.OperationMultTagHelper __Lab2_App_code_OperationMultTagHelper;
        private global::Lab2.App_code.OperationDivTagHelper __Lab2_App_code_OperationDivTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\danil\Downloads\Lab2-20200606T083631Z-001\Lab2\Lab2\Views\Calc\ModelBindingSeparateModel.cshtml"
  
    ViewData["Title"] = "ModelBindingSeparateModel";

#line default
#line hidden
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(86, 36, true);
            WriteLiteral("<h2>ModelBindingSeparateModel</h2>\r\n");
            EndContext();
            BeginContext(122, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "500a179779b84397a70ffdfedb0b3e7d", async() => {
                BeginContext(165, 75, true);
                WriteLiteral("\r\n    <input name=\"first_value\" />\r\n    <select name=\"operation\">\r\n        ");
                EndContext();
                BeginContext(240, 17, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Operation", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3e54931cd214577b40035a012c61e1d", async() => {
                }
                );
                __Lab2_App_code_OperationAddTagHelper = CreateTagHelper<global::Lab2.App_code.OperationAddTagHelper>();
                __tagHelperExecutionContext.Add(__Lab2_App_code_OperationAddTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("Add", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(257, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(267, 17, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Operation", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e93dbf43aad74bebabd7c3dfac46dea0", async() => {
                }
                );
                __Lab2_App_code_OperationSubTagHelper = CreateTagHelper<global::Lab2.App_code.OperationSubTagHelper>();
                __tagHelperExecutionContext.Add(__Lab2_App_code_OperationSubTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("Sub", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(284, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(294, 18, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Operation", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a77ae0f697094287908f0744cfb5df05", async() => {
                }
                );
                __Lab2_App_code_OperationMultTagHelper = CreateTagHelper<global::Lab2.App_code.OperationMultTagHelper>();
                __tagHelperExecutionContext.Add(__Lab2_App_code_OperationMultTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("Mult", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(312, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(322, 17, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Operation", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0400a3a413c44a0193548e8b700ed2ce", async() => {
                }
                );
                __Lab2_App_code_OperationDivTagHelper = CreateTagHelper<global::Lab2.App_code.OperationDivTagHelper>();
                __tagHelperExecutionContext.Add(__Lab2_App_code_OperationDivTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("Div", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(339, 81, true);
                WriteLiteral("\r\n    </select>\r\n    <input name=\"second_value\" />\r\n    <input type=\"submit\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
