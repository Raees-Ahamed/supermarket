#pragma checksum "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b454ca24e7c967ba151aa079efa8bb64301f3a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_NewOrder), @"mvc.1.0.view", @"/Views/Order/NewOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b454ca24e7c967ba151aa079efa8bb64301f3a6", @"/Views/Order/NewOrder.cshtml")]
    public class Views_Order_NewOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MySuperMarket.Web.ViewModel.OrderStartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<h4>Add A New Order</h4>\r\n");
#nullable restore
#line 4 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 10 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml"
   Write(Html.HiddenFor(model => model.CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml"
       Write(Html.LabelFor(model => model.CustomerName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml"
           Write(Html.EditorFor(model => model.CustomerName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 16 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml"
           Write(Html.ValidationMessageFor(model => model.CustomerName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div>
            <select asp-for=""SelectedProductId"" asp-items=""Model.AllProducts"" id=""ProductId"">
                <option>Please choose a product</option>
            </select>
        </div>
        <div class=""form-group"">
            ");
#nullable restore
#line 25 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml"
       Write(Html.LabelFor(model => model.OrderDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml"
           Write(Html.TextBoxFor(m => m.OrderDate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml"
           Write(Html.ValidationMessageFor(model => model.OrderDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Next\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\Roshan\Documents\GitHub\supermarket\MySuperMarket\MySuperMarket.Web\Views\Order\NewOrder.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n\r\n\r\n\r\n");
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
