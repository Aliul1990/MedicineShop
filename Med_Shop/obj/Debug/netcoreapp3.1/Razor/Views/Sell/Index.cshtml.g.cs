#pragma checksum "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1b9dce53ced05c372e1f4bdf62ea098ba100ad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sell_Index), @"mvc.1.0.view", @"/Views/Sell/Index.cshtml")]
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
#nullable restore
#line 6 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
using DrugHouse.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b9dce53ced05c372e1f4bdf62ea098ba100ad3", @"/Views/Sell/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a9c35c55cd10cba063aedb124d9de187069f6a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Sell_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DrugHouse.Models.Medicine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sell", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/cart.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToQuaree", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
  
    List<Medicine> medList = _httpContextAccessor.HttpContext.Session.GetObject<List<Medicine>>("cart");
    double count = 0;

    if (medList != null)
    {
        foreach (var item in medList)
        {
            count += item.Quantity;
        }
    }
    else
    {
        medList = new List<Medicine>();
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1b9dce53ced05c372e1f4bdf62ea098ba100ad37757", async() => {
                WriteLiteral(@"
                    <div class=""input-group col-8"">
                        <input type=""text"" class=""form-control"" placeholder=""Search..."" name=""Text"" />
                        <button class=""btn btn-outline-primary ml-1"" type=""submit""><i class=""bi bi-search""></i> Search</button>
                    </div>
                ");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row mb-2 mt-2\">\r\n            <div class=\"col-10\">\r\n");
#nullable restore
#line 40 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                 if (TempData["msg"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2 class=\"alert alert-primary text-center\">");
#nullable restore
#line 42 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                                                           Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 43 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-2\">\r\n\r\n");
#nullable restore
#line 47 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                 if (count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button disabled=\"disabled\" style=\"cursor:not-allowed\" class=\"btn\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e1b9dce53ced05c372e1f4bdf62ea098ba100ad311317", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("(");
#nullable restore
#line 49 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                                                                                                                                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</button>\r\n");
#nullable restore
#line 50 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1b9dce53ced05c372e1f4bdf62ea098ba100ad313167", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e1b9dce53ced05c372e1f4bdf62ea098ba100ad313447", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("(");
#nullable restore
#line 54 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                                                                                Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral(")\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <h2>Medicine List</h2>\r\n\r\n        <table class=\"table table-bordered table-striped\">\r\n            <thead>\r\n                <tr>\r\n\r\n                    <th>");
#nullable restore
#line 66 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.MedicineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 67 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 68 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.MRP));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 69 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Amount</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 74 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n                        <td>");
#nullable restore
#line 78 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                       Write(Html.DisplayFor(x => item.MedicineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 79 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                         if (item.ExpirationDate > DateTime.Now.AddMonths(1))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"bg-info\">");
#nullable restore
#line 81 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                                           Write(Html.DisplayFor(x => item.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 82 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                         if (item.ExpirationDate < DateTime.Now.AddMonths(-1))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"bg-danger\">");
#nullable restore
#line 85 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                                             Write(Html.DisplayFor(x => item.ExpirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 86 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 87 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                       Write(Html.DisplayFor(x => item.MRP));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 88 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                       Write(Html.DisplayFor(x => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1b9dce53ced05c372e1f4bdf62ea098ba100ad320987", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"mid\"");
                BeginWriteAttribute("value", " value=\"", 3426, "\"", 3450, 1);
#nullable restore
#line 91 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
WriteAttributeValue("", 3434, item.MedicineID, 3434, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"number\" name=\"qty\"");
                BeginWriteAttribute("max", " max=\"", 3519, "\"", 3539, 1);
#nullable restore
#line 92 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
WriteAttributeValue("", 3525, item.Quantity, 3525, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" value=\"1\" style=\"width:80px\" />\r\n                                <button type=\"submit\" class=\"btn btn-outline-success btn-sm\">Add</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 97 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Sell\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor _httpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DrugHouse.Models.Medicine>> Html { get; private set; }
    }
}
#pragma warning restore 1591