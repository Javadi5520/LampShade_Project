#pragma checksum "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be930b15574ba0129307959f5ab8894f2e4ffe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Areas.Administration.Pages.Inventory.Areas_Administration_Pages_Inventory_OperationLog), @"mvc.1.0.view", @"/Areas/Administration/Pages/Inventory/OperationLog.cshtml")]
namespace ServiceHost.Areas.Administration.Pages.Inventory
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be930b15574ba0129307959f5ab8894f2e4ffe7", @"/Areas/Administration/Pages/Inventory/OperationLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"207a7061cc403907cc85e7926cac9b30b57b6586", @"/Areas/Administration/Pages/_ViewImports.cshtml")]
    public class Areas_Administration_Pages_Inventory_OperationLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<InventoryManagement.Application.Contract.Inventory.InventoryOperationViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal-header"">
    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
    <h4 class=""modal-title"">سوابق گردش انبار</h4>
</div>

<div class=""modal-body"">
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>تعداد</th>
                <th>تاریخ</th>
                <th>عملیات</th>
                <th>موجودی فعلی</th>
                <th>عملگر</th>
                <th>توضیحات</th>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 726, "\"", 791, 2);
            WriteAttributeValue("", 734, "text-white", 734, 10, true);
#nullable restore
#line 25 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
WriteAttributeValue(" ", 744, item.Operation ? "bg-success" : "bg-danger", 745, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 26 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.OperationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 30 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                         if (item.Operation)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>افزایش</span>\r\n");
#nullable restore
#line 33 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>کاهش</span>\r\n");
#nullable restore
#line 37 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>");
#nullable restore
#line 39 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.CurrentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.Operator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "G:\Final\Code\LampShade\ServiceHost\Areas\Administration\Pages\Inventory\OperationLog.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-default waves-effect\" data-dismiss=\"modal\">بستن</button>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<InventoryManagement.Application.Contract.Inventory.InventoryOperationViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
