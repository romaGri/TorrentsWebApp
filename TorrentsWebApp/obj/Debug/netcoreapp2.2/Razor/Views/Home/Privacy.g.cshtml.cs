#pragma checksum "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "957c5f474f44b63b7ceab0c0bf7e28872e0b0d0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\_ViewImports.cshtml"
using TorrentsWebApp;

#line default
#line hidden
#line 2 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\_ViewImports.cshtml"
using TorrentsWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"957c5f474f44b63b7ceab0c0bf7e28872e0b0d0d", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71f86e50cd1bb42ecc0dd654316da1ba293a290e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TorrentsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(80, 310, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "957c5f474f44b63b7ceab0c0bf7e28872e0b0d0d3762", async() => {
                BeginContext(99, 104, true);
                WriteLiteral("\r\n    <div class=\"form-inline form-group\">\r\n        <label class=\"control-label\">Имя: </label>\r\n        ");
                EndContext();
                BeginContext(204, 81, false);
#line 8 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Privacy.cshtml"
   Write(Html.TextBox("name", Model.Name, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(285, 98, true);
                WriteLiteral("\r\n\r\n        \r\n        <input type=\"submit\" value=\"Фильтр\" class=\"btn btn-default\" />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(390, 204, true);
            WriteLiteral("\r\n\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Дата регистрации</th>\r\n        <th>Название</th>\r\n        <th>Размер(Б)</th>\r\n        <th>Tracker ID</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 24 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Privacy.cshtml"
     foreach (var i in Model.torrents)
    {

#line default
#line hidden
            BeginContext(641, 28, true);
            WriteLiteral("<tr><td><a href=\"Content\" />");
            EndContext();
            BeginContext(670, 4, false);
#line 26 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Privacy.cshtml"
                       Write(i.Id);

#line default
#line hidden
            EndContext();
            BeginContext(674, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(684, 13, false);
#line 26 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Privacy.cshtml"
                                     Write(i.RegistredAt);

#line default
#line hidden
            EndContext();
            BeginContext(697, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(707, 7, false);
#line 26 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Privacy.cshtml"
                                                            Write(i.Title);

#line default
#line hidden
            EndContext();
            BeginContext(714, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(724, 6, false);
#line 26 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Privacy.cshtml"
                                                                             Write(i.Size);

#line default
#line hidden
            EndContext();
            BeginContext(730, 14, true);
            WriteLiteral(" Byte</td><td>");
            EndContext();
            BeginContext(745, 11, false);
#line 26 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Privacy.cshtml"
                                                                                                  Write(i.TrackerId);

#line default
#line hidden
            EndContext();
            BeginContext(756, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 27 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Privacy.cshtml"
    }

#line default
#line hidden
            BeginContext(775, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorrentsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591