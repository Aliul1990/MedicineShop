#pragma checksum "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Expense\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "582d1c3863cfd99e6b34b3e6a7e9d0f1ee552cab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expense_Create), @"mvc.1.0.view", @"/Views/Expense/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"582d1c3863cfd99e6b34b3e6a7e9d0f1ee552cab", @"/Views/Expense/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a9c35c55cd10cba063aedb124d9de187069f6a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Expense_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DrugHouse.Models.Expense>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card m-2\">\r\n    <div class=\"card-header\">\r\n        <h4>Create New Expense</h4>\r\n        <h6 class=\"card-subtitle text-muted m-2\">Fill up the Form And Save</h6>\r\n    </div>\r\n    <div class=\"card-body \">\r\n");
#nullable restore
#line 9 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Expense\Create.cshtml"
         using (Html.BeginForm("Create", "Expense", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row mb-1\">\r\n                ");
#nullable restore
#line 12 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Expense\Create.cshtml"
           Write(Html.LabelFor(x => x.Cost, new { @class = "col-form-label col-form-label-sm col-2 r" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-6\">\r\n                    ");
#nullable restore
#line 14 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Expense\Create.cshtml"
               Write(Html.TextBoxFor(x => x.Cost, new { @class = "form-control form-control-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Expense\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.Cost, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row mb-1\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Expense\Create.cshtml"
           Write(Html.LabelFor(x => x.Details, new { @class = "col-form-label col-form-label-sm col-2 r" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-6\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Expense\Create.cshtml"
               Write(Html.TextBoxFor(x => x.Details, new { @class = "form-control form-control-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Expense\Create.cshtml"
               Write(Html.ValidationMessageFor(x => x.Details, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row mb-1"">
                <div class=""col-10 offset-2"">
                    <button type=""submit"" title=""Add New"" class=""btn btn-outline-success""><i class=""bi bi-save""></i> Save</button>
                </div>
            </div>
");
#nullable restore
#line 35 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Expense\Create.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 1587, "\"", 1624, 1);
#nullable restore
#line 37 "C:\Users\Aliul\source\repos\Med_Shop_Core\Final_Med_Shop\Med_Shop\Views\Expense\Create.cshtml"
WriteAttributeValue("", 1594, Url.Action("Index","Expense"), 1594, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Back To List\" class=\"card-link float-sm-start\"><i class=\"bi bi-arrow-left\"></i> Back to list</a>\r\n    </div>\r\n    <div class=\"card-footer\"></div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DrugHouse.Models.Expense> Html { get; private set; }
    }
}
#pragma warning restore 1591
