#pragma checksum "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56b40eed68904375f515dde7a4c50fb47f464dc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\_ViewImports.cshtml"
using Lulus.CustomerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\_ViewImports.cshtml"
using Lulus.CustomerApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b40eed68904375f515dde7a4c50fb47f464dc2", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14681e86aeecef6061f4c0c3e61966577519aa45", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lulus.ViewModels.Order.CurrentCartRespond>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClearCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeQuantity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    .cart {\r\n        margin-top: 10px;\r\n        margin-left: 20%;\r\n        margin-right: 20%;\r\n    }\r\n</style>\r\n<div class=\"cart\">\r\n    <p hidden>");
#nullable restore
#line 10 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
         Write(Model.Order_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h2>My Cart</h2>\r\n    <p>");
#nullable restore
#line 12 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
  Write(Model.DetailCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" products</p>\r\n");
#nullable restore
#line 13 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
      double count = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
     if (Model.DetailCount == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Empty cart</p>\r\n");
#nullable restore
#line 17 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56b40eed68904375f515dde7a4c50fb47f464dc26554", async() => {
                WriteLiteral("Clear cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
                                                               WriteLiteral(Model.Order_ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
         foreach (var item in Model.OrderDetails)
        {
            count += item.Product_SellPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-10\">\r\n                        <h4>");
#nullable restore
#line 27 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
                       Write(item.Product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 28 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
                      Write(item.Product_SellPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\r\n                        <p>Size ");
#nullable restore
#line 29 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
                           Write(item.SizeKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Quantity:  \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56b40eed68904375f515dde7a4c50fb47f464dc210270", async() => {
                WriteLiteral("\r\n                                <input name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1088, "\"", 1116, 1);
#nullable restore
#line 32 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1096, item.OrderDetail_ID, 1096, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden/>\r\n                                <input");
                BeginWriteAttribute("value", " value=\"", 1166, "\"", 1200, 1);
#nullable restore
#line 33 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1174, item.OrderDetail_Quantity, 1174, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Quantity\"/>\r\n                                <button type=\"submit\">Update</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </p>\r\n\r\n                    </div>\r\n                    <div class=\"col-md-2\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1461, "\"", 1486, 1);
#nullable restore
#line 40 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1467, item.Product_Image, 1467, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" height=\"100%\" />\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56b40eed68904375f515dde7a4c50fb47f464dc213728", async() => {
                WriteLiteral("Remove");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderDetailID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
                                                                                                                      WriteLiteral(item.OrderDetail_ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderDetailID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderDetailID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderDetailID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n            </div>\r\n            <hr />\r\n");
#nullable restore
#line 46 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-10\">\r\n                    <p>Total:</p>\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n                    <h3 style=\"text-align:right\">");
#nullable restore
#line 53 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
                                            Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h3>\r\n                    <a href=\"#\" class=\"btn btn-dark\">Checkout</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 58 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lulus.ViewModels.Order.CurrentCartRespond> Html { get; private set; }
    }
}
#pragma warning restore 1591
