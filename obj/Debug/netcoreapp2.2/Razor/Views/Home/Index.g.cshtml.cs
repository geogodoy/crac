#pragma checksum "C:\Users\AnaDaniela\Desktop\EmbarcadosIII\Crac\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb05ddf0b18f9b4feae4e55838d89ff647cfc474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\AnaDaniela\Desktop\EmbarcadosIII\Crac\Views\_ViewImports.cshtml"
using Crac;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb05ddf0b18f9b4feae4e55838d89ff647cfc474", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e655c13f6fa4eb9d342ac6eecf1bcea7e59f075c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CRAC.Api.SQLite.Moviment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\AnaDaniela\Desktop\EmbarcadosIII\Crac\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 1137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb05ddf0b18f9b4feae4e55838d89ff647cfc4744322", async() => {
                BeginContext(143, 163, true);
                WriteLiteral("\r\n  \r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <div class=\"form-group\">\r\n                <label for=\"name\">Left</label>\r\n                ");
                EndContext();
                BeginContext(307, 60, false);
#line 13 "C:\Users\AnaDaniela\Desktop\EmbarcadosIII\Crac\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(m => m.Left, new { @class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(367, 174, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n         <div class=\"col-md-3\">\r\n            <div class=\"form-group\">\r\n                <label for=\"name\">Right</label>\r\n                ");
                EndContext();
                BeginContext(542, 77, false);
#line 19 "C:\Users\AnaDaniela\Desktop\EmbarcadosIII\Crac\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(m => m.Right, new { @class = "form-control" , type="number"}));

#line default
#line hidden
                EndContext();
                BeginContext(619, 173, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n         <div class=\"col-md-3\">\r\n            <div class=\"form-group\">\r\n                <label for=\"name\">Claw</label>\r\n                ");
                EndContext();
                BeginContext(793, 60, false);
#line 25 "C:\Users\AnaDaniela\Desktop\EmbarcadosIII\Crac\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(m => m.Claw, new { @class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(853, 173, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n         <div class=\"col-md-3\">\r\n            <div class=\"form-group\">\r\n                <label for=\"name\">Base</label>\r\n                ");
                EndContext();
                BeginContext(1027, 60, false);
#line 31 "C:\Users\AnaDaniela\Desktop\EmbarcadosIII\Crac\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(m => m.Base, new { @class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1087, 125, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n  <input type=\"submit\" class=\"btn btn-primary btn-block\" name=\"submit\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRAC.Api.SQLite.Moviment> Html { get; private set; }
    }
}
#pragma warning restore 1591
