#pragma checksum "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bbff37913843381f36380a368eaa8f0c3a8f29e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction__ViewAll), @"mvc.1.0.view", @"/Views/Transaction/_ViewAll.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\_ViewImports.cshtml"
using JQueryAjaxCRUD_PopUp_Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\_ViewImports.cshtml"
using JQueryAjaxCRUD_PopUp_Dialog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bbff37913843381f36380a368eaa8f0c3a8f29e", @"/Views/Transaction/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d46c729d554037d56d5362d8d6710bb454058a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JQueryAjaxCRUD_PopUp_Dialog.Models.TransactionModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n<table class=\"table table-hover\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.BenificiaryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 598, "\"", 708, 5);
            WriteAttributeValue("", 608, "showInPopup(\'", 608, 13, true);
#nullable restore
#line 19 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
WriteAttributeValue("", 621, Url.Action("AddorEdit","Transaction",null,Context.Request.Scheme), 621, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 687, "\',", 687, 2, true);
            WriteAttributeValue(" ", 689, "\'New", 690, 5, true);
            WriteAttributeValue(" ", 694, "Transaction\')", 695, 14, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\"><i class=\"fas fa-random\"></i> New Transaction</a>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.BenificiaryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1359, "\"", 1502, 5);
            WriteAttributeValue("", 1369, "showInPopup(\'", 1369, 13, true);
#nullable restore
#line 41 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
WriteAttributeValue("", 1382, Url.Action("AddorEdit", "Transaction", new { id = item.TransactionID }, Context.Request.Scheme), 1382, 96, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1478, "\',", 1478, 2, true);
            WriteAttributeValue(" ", 1480, "\'Update", 1481, 8, true);
            WriteAttributeValue(" ", 1488, "Transaction\')", 1489, 14, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\"><i class=\"fas fa-pencil-alt\"></i> Edit</a> \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bbff37913843381f36380a368eaa8f0c3a8f29e9223", async() => {
                WriteLiteral(" | \r\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
                                            WriteLiteral(item.TransactionID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n         </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Yadnyesh\source\repos\JQueryAjaxCRUD_PopUp Dialog\Views\Transaction\_ViewAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JQueryAjaxCRUD_PopUp_Dialog.Models.TransactionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
