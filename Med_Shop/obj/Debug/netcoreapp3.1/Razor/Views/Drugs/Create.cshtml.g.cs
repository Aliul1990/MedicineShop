#pragma checksum "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf629797cbd025c76a00e41ed7e9bc3739fc23f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drugs_Create), @"mvc.1.0.view", @"/Views/Drugs/Create.cshtml")]
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
#line 1 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\_ViewImports.cshtml"
using Med_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\_ViewImports.cshtml"
using Med_Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf629797cbd025c76a00e41ed7e9bc3739fc23f6", @"/Views/Drugs/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a9c35c55cd10cba063aedb124d9de187069f6a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Drugs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Med_Shop.Models.ViewModel.MedicineVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Drugs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row mt-2\">\r\n    <div class=\"col\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf629797cbd025c76a00e41ed7e9bc3739fc23f65090", async() => {
                WriteLiteral("\r\n            <div class=\"row mb-1\">\r\n                ");
#nullable restore
#line 7 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
           Write(Html.LabelFor(x => x.MedicineName, new { @class = "col-form-label col-form-label col-2 r" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-6\">\r\n                    ");
#nullable restore
#line 9 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.TextBoxFor(x => x.MedicineName, new { @class = "form-control form-control r" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    ");
#nullable restore
#line 12 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.MedicineName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row mb-1\">\r\n                ");
#nullable restore
#line 16 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
           Write(Html.LabelFor(x => x.TreadPrice, new { @class = "col-form-label col-form-label col-2 r" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-6\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.TextBoxFor(x => x.TreadPrice, new { @class = "form-control form-control r" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.TreadPrice, "", new { @class = "text-danger", Type = "money" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row mb-1\">\r\n                ");
#nullable restore
#line 25 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
           Write(Html.LabelFor(x => x.MRP, new { @class = "col-form-label col-form-label col-2 r" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-6\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.TextBoxFor(x => x.MRP, new { @class = "form-control", Type = "money" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.MRP, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row mb-1\">\r\n                ");
#nullable restore
#line 34 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
           Write(Html.LabelFor(x => x.Quantity, new { @class = "col-form-label col-form-label col-2 r" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-6\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.TextBoxFor(x => x.Quantity, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    ");
#nullable restore
#line 39 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.Quantity, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row mb-1\">\r\n                ");
#nullable restore
#line 43 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
           Write(Html.LabelFor(x => x.GenericID, new { @class = "col-form-label col-form-label col-2 r" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-6\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf629797cbd025c76a00e41ed7e9bc3739fc23f610610", async() => {
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 45 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GenericID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 45 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList( ViewBag.Gen,"GenericID","GenericName"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    ");
#nullable restore
#line 49 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.GenericID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row mb-1\">\r\n                ");
#nullable restore
#line 53 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
           Write(Html.LabelFor(x => x.ProviderID, new { @class = "col-form-label col-form-label col-2 r" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-6\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf629797cbd025c76a00e41ed7e9bc3739fc23f613684", async() => {
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 55 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProviderID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 55 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList( ViewBag.Prov ,"ProviderID","ProviderName"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    ");
#nullable restore
#line 59 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.ProviderID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row mb-1\">\r\n                ");
#nullable restore
#line 63 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
           Write(Html.LabelFor(x => x.Picture, new { @class = "col-form-label col-form-label col-2 r" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-6\">\r\n                    ");
#nullable restore
#line 65 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.TextBoxFor(x => x.Picture, new { @class = "form-control", Type = "file" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    ");
#nullable restore
#line 68 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.Picture, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>

            <div class=""row mb-1"">
                <div class=""col-10 offset-2"">
                    <button type=""submit"" title=""Save"" class=""btn btn-outline-success""><i class=""bi bi-save""></i> Save</button>
                </div>
            </div>
            <div id=""msg"">
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 4105, "\"", 4140, 1);
#nullable restore
#line 80 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Drugs\Create.cshtml"
WriteAttributeValue("", 4112, Url.Action("Index","Drugs"), 4112, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Back To List\" class=\"card-link float-sm-start\"><i class=\"bi bi-arrow-left\"></i> Back to list</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Med_Shop.Models.ViewModel.MedicineVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
