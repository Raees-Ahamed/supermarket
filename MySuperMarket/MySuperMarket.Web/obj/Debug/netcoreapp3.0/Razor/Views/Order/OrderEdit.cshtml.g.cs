#pragma checksum "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86ac83e7175dfa2ed853eb228868befb55e4e143"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderEdit), @"mvc.1.0.view", @"/Views/Order/OrderEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86ac83e7175dfa2ed853eb228868befb55e4e143", @"/Views/Order/OrderEdit.cshtml")]
    public class Views_Order_OrderEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MySuperMarket.Web.ViewModel.OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml"
  

    ViewBag.Title = "OrderEdit";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h2>OrderEdit</h2>\r\n<div id=\"errorMessages1\" class=\"alert-danger\"></div>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderCustomer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 17 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml"
       Write(Html.DisplayFor(model => model.OrderCustomer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 20 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 23 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 26 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml"
       Write(Html.DisplayNameFor(model => model.ShippingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml"
       Write(Html.DisplayFor(model => model.ShippingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
</div>
<input type=""hidden"" id=""isOrderEdited"" value=""false"" />
<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-md"" role=""document"">
        <div class=""modal-content"">
            <div id=""errorMessages"" class=""alert-danger""></div>
            <table id=""ProductSelect"" class=""table orderLine1 "">
                <thead>
                    <tr>
                        <th style=""width:20%"">Product</th>
                        <th style=""width:30%"">Product Description</th>
                        <th style=""width:10%"">Price</th>
                        <th style=""width:8%"">Quantity</th>
                        <th style=""width:22%"" class=""text-center"">Subtotal</th>
                        <th style=""width:10%""></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td data-th=");
            WriteLiteral("\"Product\"><input type=\"text\" id=\"ProductName\" class=\"form-control text-center \"");
            BeginWriteAttribute("value", " value=\"", 1867, "\"", 1875, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                        <td data-th=\"Description\"><input type=\"text\" id=\"ProductDescription\" class=\"form-control text-center \"");
            BeginWriteAttribute("value", " value=\"", 2012, "\"", 2020, 0);
            EndWriteAttribute();
            WriteLiteral(" readonly /></td>\r\n                        <td data-th=\"Price\"><input type=\"number\" id=\"ProductPrice\" class=\"form-control text-center \"");
            BeginWriteAttribute("value", " value=\"", 2156, "\"", 2164, 0);
            EndWriteAttribute();
            WriteLiteral(@" readonly /></td>
                        <td data-th=""Quantity"">
                            <input type=""number"" id=""ProductQuantity"" class=""form-control text-center "">
                        </td>
                        <td data-th=""Subtotal"" class=""text-center"">
                            <input type=""text"" id=""ProductSubTotal"" class=""form-control text-center  """);
            BeginWriteAttribute("value", " value=\"", 2541, "\"", 2549, 0);
            EndWriteAttribute();
            WriteLiteral(" readonly>\r\n                        </td>\r\n                        <td class=\"actions\" data-th=\"\">\r\n                            <input type=\"hidden\" id=\"ProductId\"");
            BeginWriteAttribute("value", " value=\"", 2713, "\"", 2721, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <input type=\"hidden\" id=\"ProductAvailableStock\"");
            BeginWriteAttribute("value", " value=\"", 2802, "\"", 2810, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <input type=\"hidden\" id=\"OrderItemId\"");
            BeginWriteAttribute("value", " value=\"", 2881, "\"", 2889, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                </tfoot>
            </table>
            <div id=""errorMessages"" class=""alert-danger""></div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" id=""EditOrderItemClose"">Close</button>
                <button type=""button"" class=""btn btn-primary"" id=""EditOrderItem"">Save</button>
            </div>
        </div>
    </div>
</div>
<div>
    <input type=""hidden"" id=""OderDateID""");
            BeginWriteAttribute("value", " value=\"", 3460, "\"", 3479, 1);
#nullable restore
#line 80 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml"
WriteAttributeValue("", 3468, Model.Date, 3468, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"CustomerId\"");
            BeginWriteAttribute("value", " value=\"", 3525, "\"", 3556, 1);
#nullable restore
#line 81 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml"
WriteAttributeValue("", 3533, Model.OrderCustomer.Id, 3533, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"OrderId\"");
            BeginWriteAttribute("value", " value=\"", 3599, "\"", 3616, 1);
#nullable restore
#line 82 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml"
WriteAttributeValue("", 3607, Model.Id, 3607, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n<div id=\"orderEditItem\">\r\n    ");
#nullable restore
#line 85 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\OrderEdit.cshtml"
Write(Html.Partial("_OrderItemList", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    <button type=\"button\" class=\"btn btn-primary\" id=\"UpdateEditedItem\"> Update Order</button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MySuperMarket.Web.ViewModel.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
