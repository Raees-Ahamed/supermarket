#pragma checksum "D:\InexisProject\MySuperMarket\MySuperMarket.Web\Views\Order\_RecentOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7a1c204c3c8c2712cc14bd42adb98e35f104d16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order__RecentOrders), @"mvc.1.0.view", @"/Views/Order/_RecentOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7a1c204c3c8c2712cc14bd42adb98e35f104d16", @"/Views/Order/_RecentOrders.cshtml")]
    public class Views_Order__RecentOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MySuperMarket.Web.ViewModel.OrderStartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table id=""RecentOrders"" class=""table "">
    <thead>
        <tr>
            <th style=""width:4% ""></th>
            <th style=""width:20%"">Customer</th>
            <th style=""width:20%"">Order Date</th>
            <th style=""width:20%"">Shipping Address</th>
            <th style=""width:8%"">Total Price</th>
            <th style=""width:22%"" class=""text-center""></th>
            <th style=""width:10%""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "D:\InexisProject\MySuperMarket\MySuperMarket.Web\Views\Order\_RecentOrders.cshtml"
         foreach (var order in Model.RecentOrders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td data-th=\"OrderId\" style=\"visibility:hidden\">");
#nullable restore
#line 19 "D:\InexisProject\MySuperMarket\MySuperMarket.Web\Views\Order\_RecentOrders.cshtml"
                                                           Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td data-th=\"Product\">");
#nullable restore
#line 20 "D:\InexisProject\MySuperMarket\MySuperMarket.Web\Views\Order\_RecentOrders.cshtml"
                                 Write(order.OrderCustomer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td data-th=\"Description\">");
#nullable restore
#line 21 "D:\InexisProject\MySuperMarket\MySuperMarket.Web\Views\Order\_RecentOrders.cshtml"
                                     Write(order.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td data-th=\"Price\">");
#nullable restore
#line 22 "D:\InexisProject\MySuperMarket\MySuperMarket.Web\Views\Order\_RecentOrders.cshtml"
                               Write(order.ShippingAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td data-th=\"Quantity\">");
#nullable restore
#line 23 "D:\InexisProject\MySuperMarket\MySuperMarket.Web\Views\Order\_RecentOrders.cshtml"
                                  Write(order.OrderTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 25 "D:\InexisProject\MySuperMarket\MySuperMarket.Web\Views\Order\_RecentOrders.cshtml"
               Write(Html.ActionLink("Edit", "OrderEdit", new { id = order.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 26 "D:\InexisProject\MySuperMarket\MySuperMarket.Web\Views\Order\_RecentOrders.cshtml"
               Write(Html.ActionLink("Details", "OrderDetails", new { id = order.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    <a href=\"javascript:void(0)\" class=\"deleteRecentOrder\"> Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "D:\InexisProject\MySuperMarket\MySuperMarket.Web\Views\Order\_RecentOrders.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n    </tfoot>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MySuperMarket.Web.ViewModel.OrderStartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591