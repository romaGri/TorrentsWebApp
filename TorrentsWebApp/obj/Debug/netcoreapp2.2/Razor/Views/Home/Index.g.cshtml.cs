#pragma checksum "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "439f745dc5afe0331e631c8c06af57cca206bae6"
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
#line 1 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\_ViewImports.cshtml"
using TorrentsWebApp;

#line default
#line hidden
#line 1 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
using TorrentsWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"439f745dc5afe0331e631c8c06af57cca206bae6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71f86e50cd1bb42ecc0dd654316da1ba293a290e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(100, 436, true);
            WriteLiteral(@"

<style>
    table {
        width: 100%;
        border-collapse: collapse;
    }

    td, th {
        padding: 3px;
        border: 1px solid #000; /* Параметры рамки */
    }

    th {
        background: #afd792;
        color: #333; /* Цвет текста */
    }

    tbody tr:hover {
        background: #f3bd48; /* Цвет фона при наведении */
        color: #fff; /* Цвет текста при наведении */
    }
</style>
");
            EndContext();
            BeginContext(536, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "439f745dc5afe0331e631c8c06af57cca206bae65467", async() => {
                BeginContext(596, 125, true);
                WriteLiteral("\r\n    <p>\r\n        Title: <input type=\"text\" name=\"SearchString\">\r\n        <input type=\"submit\" value=\"Filter\" />\r\n    </p>\r\n");
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
            BeginContext(728, 452, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Table Torrents</h1>
    <table class=""table"">
        <tr>
            <td>
                ID
            </td>
            <td>
                Дата регистрации
            </td>
            <td>
                Название
            </td>
            <td>
                Размер(Б)
            </td>
            <td>
                Tracker ID
            </td>
        </tr>
");
            EndContext();
#line 56 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
         foreach (Torrents i in Model.torrents)
        {

#line default
#line hidden
            BeginContext(1240, 40, true);
            WriteLiteral("            <tr><td><a href=\"Content\" />");
            EndContext();
            BeginContext(1281, 4, false);
#line 58 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
                                   Write(i.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1285, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(1295, 13, false);
#line 58 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
                                                 Write(i.RegistredAt);

#line default
#line hidden
            EndContext();
            BeginContext(1308, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(1318, 7, false);
#line 58 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
                                                                        Write(i.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1325, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(1335, 6, false);
#line 58 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
                                                                                         Write(i.Size);

#line default
#line hidden
            EndContext();
            BeginContext(1341, 14, true);
            WriteLiteral(" Byte</td><td>");
            EndContext();
            BeginContext(1356, 11, false);
#line 58 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
                                                                                                              Write(i.TrackerId);

#line default
#line hidden
            EndContext();
            BeginContext(1367, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 59 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1390, 16, true);
            WriteLiteral("    </table>\r\n\r\n");
            EndContext();
#line 62 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
     if (Model.PageInfo.HasPreviousPage)
    {

#line default
#line hidden
            BeginContext(1455, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1463, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "439f745dc5afe0331e631c8c06af57cca206bae611027", async() => {
                BeginContext(1587, 91, true);
                WriteLiteral("\r\n            <i class=\"glyphicon glyphicon-chevron-left\"></i>\r\n            Назад\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
                WriteLiteral(Model.PageInfo.PageNumber - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1682, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 70 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1691, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 71 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
     if (Model.PageInfo.HasNextPage)
    {

#line default
#line hidden
            BeginContext(1736, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1744, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "439f745dc5afe0331e631c8c06af57cca206bae614081", async() => {
                BeginContext(1868, 93, true);
                WriteLiteral("\r\n            Вперед\r\n            <i class=\"glyphicon glyphicon-chevron-right\"></i>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
                WriteLiteral(Model.PageInfo.PageNumber + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1965, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 79 "C:\Users\Raman_Hrytsuk\source\repos\TorrentsWebApp\TorrentsWebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1974, 124, true);
            WriteLiteral("    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591