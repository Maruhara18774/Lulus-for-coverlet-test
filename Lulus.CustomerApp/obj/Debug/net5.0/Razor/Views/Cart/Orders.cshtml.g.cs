#pragma checksum "C:\Users\ad\OneDrive\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6797c8beba75f2f7bb45fef3794bf6d4cd00626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Orders), @"mvc.1.0.view", @"/Views/Cart/Orders.cshtml")]
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
#line 1 "C:\Users\ad\OneDrive\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\_ViewImports.cshtml"
using Lulus.CustomerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ad\OneDrive\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\_ViewImports.cshtml"
using Lulus.CustomerApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6797c8beba75f2f7bb45fef3794bf6d4cd00626", @"/Views/Cart/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef9c734a7b65165787890fdb3c0b7cf1ee2e046", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Lulus.ViewModels.Order.OrderRespond>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    .cart {\r\n        margin-top: 10px;\r\n        margin-left: 20%;\r\n        margin-right: 20%;\r\n    }\r\n</style>\r\n<div class=\"cart\">\r\n");
#nullable restore
#line 10 "C:\Users\ad\OneDrive\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Orders.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Order Key: ");
#nullable restore
#line 12 "C:\Users\ad\OneDrive\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Orders.cshtml"
                         Write(item.Order_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Created Date: ");
#nullable restore
#line 13 "C:\Users\ad\OneDrive\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Orders.cshtml"
                            Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 14 "C:\Users\ad\OneDrive\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Orders.cshtml"
              Write(item.DetailCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" products</p>\r\n                <p>Status: ");
#nullable restore
#line 15 "C:\Users\ad\OneDrive\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Orders.cshtml"
                      Write(item.Status.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Total: ");
#nullable restore
#line 16 "C:\Users\ad\OneDrive\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Orders.cshtml"
                     Write(item.Order_Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <hr/>\r\n");
#nullable restore
#line 18 "C:\Users\ad\OneDrive\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Orders.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Lulus.ViewModels.Order.OrderRespond>> Html { get; private set; }
    }
}
#pragma warning restore 1591
