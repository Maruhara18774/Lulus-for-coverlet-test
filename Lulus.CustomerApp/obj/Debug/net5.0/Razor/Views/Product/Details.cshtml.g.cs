#pragma checksum "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ac7a66d3e16f7a6ce3e97d87302aaf9f1d88afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#nullable restore
#line 2 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
using Lulus.ViewModels.Feedbacks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
using Lulus.ViewModels.Order;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac7a66d3e16f7a6ce3e97d87302aaf9f1d88afe", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14681e86aeecef6061f4c0c3e61966577519aa45", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lulus.CustomerApp.Models.Products.DetailProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("lineBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailChoosing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .chooseBox{
        border-style:solid;
        border-color:gainsboro;
        background-color:gainsboro;
        padding:10px;
        border-radius:15px;
        padding-left:5%;
    }
    .lineBtn {
        text-decoration: none;
        cursor: pointer;
        color: black
    }
        .lineBtn:hover {
            text-decoration: none;
        }
    .sizeKey {
        display: inline-block;
        margin-right: 5px;
    }
    .icon-map{
        text-align:center;
        margin-top:5px;
    }
    .icon-map a {
        text-decoration: none;
        color:black;
        margin:5px;
    }
    .customerReview{
        margin:10%;
    }
    .ratingBox{
        margin-left:20px
    }
</style>
<div class=""container"" style=""margin-top:20px"">
    <div class=""row"">
        <div class=""col-md-1"">
");
#nullable restore
#line 44 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
               var currentLine = Model.ListProductLines.Where(x => x.ID == Model.CurrentLine).FirstOrDefault(); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
             foreach (var image in currentLine.ListImages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 1197, "\"", 1219, 1);
#nullable restore
#line 47 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
WriteAttributeValue("", 1203, image.Image_Url, 1203, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"sub-image\" style=\"width:50px; margin-bottom:20px\" />\r\n");
#nullable restore
#line 48 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-4\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1359, "\"", 1401, 1);
#nullable restore
#line 51 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
WriteAttributeValue("", 1365, currentLine.ListImages[0].Image_Url, 1365, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:100%"" />
            <div class=""icon-map"">
                <a href=""#"">
                    <i class=""fab fa-instagram""></i>
                </a>
                <a href=""#"">
                    <i class=""fab fa-pinterest-p""></i>
                </a>
                <a href=""#"">
                    <i class=""fab fa-facebook-f""></i>
                </a>
                <a href=""#"">
                    <i class=""fab fa-twitter""></i>
                </a>
                <a href=""#"">
                    <i class=""fab fa-youtube""></i>
                </a>
            </div>
            <hr />
            <p>
                <span style=""font-size:large"">#LOVELULUS</span>
                Tag your photos on Instagram for a chance to WIN $250!
            </p>
        </div>
        <div class=""col-md-7"">
            <h3>");
#nullable restore
#line 76 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>Lulus | (");
#nullable restore
#line 77 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                   Write(Model.ListFeedbacks.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n");
#nullable restore
#line 78 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
             if (Model.SalePrice != Model.Price)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3><span style=\"text-decoration:line-through\">$");
#nullable restore
#line 80 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> $");
#nullable restore
#line 80 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                                                Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 81 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3>$");
#nullable restore
#line 84 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 85 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"chooseBox\">\r\n                <div>\r\n                    <h4>Colors</h4>\r\n");
#nullable restore
#line 89 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                     foreach (var line in Model.ListProductLines)
                    {
                        if (line.ID == currentLine.ID)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"lineBtn\" style=\"color:orange\">\r\n                                <p><span><img");
            BeginWriteAttribute("src", " src=\"", 3003, "\"", 3032, 1);
#nullable restore
#line 94 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
WriteAttributeValue("", 3009, line.Texture_Image_Url, 3009, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Texture image\" /></span> ");
#nullable restore
#line 94 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                                                                     Write(line.Texture_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </a>\r\n");
#nullable restore
#line 96 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ac7a66d3e16f7a6ce3e97d87302aaf9f1d88afe12555", async() => {
                WriteLiteral("\r\n                                <p><span><img");
                BeginWriteAttribute("src", " src=\"", 3397, "\"", 3426, 1);
#nullable restore
#line 100 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
WriteAttributeValue("", 3403, line.Texture_Image_Url, 3403, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Texture image\" /></span> ");
#nullable restore
#line 100 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                                                                     Write(line.Texture_Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                                                               WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                                                                                          WriteLiteral(line.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["line"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-line", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["line"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 102 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <p>Size sold out? <a href=\"#\">Join the Waitlist</a></p>\r\n                <div style=\"display:inline-block\">\r\n");
#nullable restore
#line 108 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                     foreach (var size in currentLine.ListSizes)
                    {
                        if (size.Quantity == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"btn btn-light sizeKey\" disabled>");
#nullable restore
#line 112 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                                      Write(size.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 113 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                        }
                        else
                        {
                            if (size.ID == Model.CurrentSizeID)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  <button class=\"btn btn-light sizeKey border-2\" data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 4280, "\"", 4312, 2);
            WriteAttributeValue("", 4288, "Quantity:", 4288, 9, true);
#nullable restore
#line 118 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
WriteAttributeValue(" ", 4297, size.Quantity, 4298, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 118 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                                                                                                                        Write(size.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 119 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ac7a66d3e16f7a6ce3e97d87302aaf9f1d88afe19411", async() => {
                WriteLiteral("\r\n                                    <button class=\"btn btn-light sizeKey\" data-toggle=\"tooltip\" data-placement=\"top\"");
                BeginWriteAttribute("title", " title=\"", 4947, "\"", 4979, 2);
                WriteAttributeValue("", 4955, "Quantity:", 4955, 9, true);
#nullable restore
#line 128 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
WriteAttributeValue(" ", 4964, size.Quantity, 4965, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 128 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                                                                                                                 Write(size.Key);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                     WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 125 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                       WriteLiteral(Model.CurrentLine);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["line"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-line", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["line"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                           WriteLiteral(Model.CurrentQuantity);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["quantity"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-quantity", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["quantity"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                       WriteLiteral(size.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["size"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-size", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["size"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 130 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                            }

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <p>\r\n                    <a><i class=\"fas fa-ruler-horizontal\"></i> Size Chart</a>\r\n                    |\r\n                    <b>Fit Note: Fit is true to size.</b>\r\n                </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ac7a66d3e16f7a6ce3e97d87302aaf9f1d88afe25422", async() => {
                WriteLiteral("\r\n                    <button class=\"btn btn-lg btn-dark\">ADD TO BAG</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 140 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                                    WriteLiteral(Model.CurrentLine);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 140 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                                                       WriteLiteral(Model.CurrentSizeID);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 140 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                                                                                            WriteLiteral(Model.CurrentQuantity);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <p><i class=""fas fa-shipping-fast""></i> Free International Shipping on orders over $150 with code WorldWide! <a href=""#"">See More</a></p>
            </div>
            <br/>
            <h3>Description</h3>
            <hr />
            <p>");
#nullable restore
#line 148 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"customerReview\">\r\n    <h3>Customer review</h3>\r\n");
#nullable restore
#line 154 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
     if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"ratingBox\">\r\n    ");
#nullable restore
#line 157 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
Write(await Html.PartialAsync("Rating", new CreateFeedbackRequest(Model.ID)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 159 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
     if(Model.ListFeedbacks.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>It\'s still not rated :(</p>\r\n");
#nullable restore
#line 163 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Title</th>
                            <th>Star</th>
                            <th>Content</th>
                            <th>Create day</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 176 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                         foreach(var review in Model.ListFeedbacks)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 179 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                                       Write(review.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 180 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                           Write(review.Star);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</td>\r\n                            <td>");
#nullable restore
#line 181 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                           Write(review.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 182 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                           Write(review.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 184 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 187 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-light\" style=\"margin-left:45%\" onclick=\"topFunction()\">Back to top</button>\r\n</div>\r\n<script>\r\n    function topFunction() {\r\n        document.body.scrollTop = 0;\r\n        document.documentElement.scrollTop = 0;\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lulus.CustomerApp.Models.Products.DetailProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
