#pragma checksum "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e290de2b44aef61c551fd294d5e232b0b13781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 2 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
using Lulus.CustomerApp.Models.Products;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e290de2b44aef61c551fd294d5e232b0b13781", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14681e86aeecef6061f4c0c3e61966577519aa45", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lulus.CustomerApp.Models.Products.ProductCategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FullList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:chocolate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<style>
    .sort-bar {
        max-width: 300px;
        padding-left: 10%;
        padding-right: 10%;
        vertical-align: text-top
    }

        .sort-bar a {
            text-decoration: none;
            color: black;
        }

    .content {
        top: 0;
    }

    .content__textureimage {
        border-radius: 50px;
        cursor: pointer;
        margin-top: 10px;
        border-style: solid;
        border-color: gainsboro;
        border-width: 2px
    }

    .content__productimage {
        width: 100%
    }

    .mytable {
    }

        .mytable td {
            vertical-align: top;
            padding-top: 20px;
        }
    .content__price {
        font-size: large;
        padding-left: 10px
    }

    .content__more {
        margin-left: 45%;
        text-decoration: none;
        color: orange;
    }

        .content__more :hover {
            color: aqua;
            text-decoration: none
        }

    .thumbnail {
        position: relative;
        cursor: pointer;
    }
");
            WriteLiteral(@"
    .thumbnail__image {
        opacity: 1;
        display: block;
        width: 100%;
        height: auto;
        transition: .5s ease;
        backface-visibility: hidden;
    }

    .thumbnail__content {
        transition: .5s ease;
        opacity: 0;
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        -ms-transform: translate(-50%, -50%);
        text-align: center;
    }

        .thumbnail__content a {
            text-decoration: none;
            color: dimgray;
            font-size: large
        }

    .thumbnail:hover .thumbnail__image {
        opacity: 0.3;
    }

    .thumbnail:hover .thumbnail__content {
        opacity: 1;
    }
</style>
<table style=""width: 100%"" class=""mytable"">
    <tr>
        <td>
            <div class=""sort-bar"">
                <h3>Refine By</h3>
                <br />
                <h4>Size</h4>
                <hr />
");
#nullable restore
#line 104 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                 foreach (var size in Model.ListSizes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\n                        <span><input type=\"checkbox\" /></span>\n                        ");
#nullable restore
#line 108 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                   Write(size.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <br />\n");
#nullable restore
#line 111 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>Price</h4>\n                ");
#nullable restore
#line 113 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
           Write(await Html.PartialAsync("Sort", new SortModel(ViewBag.CateID, ViewBag.SubcateID)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <hr />\n                <h4>Category</h4>\n");
#nullable restore
#line 116 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                 foreach (var subCate in Model.ListSubCategories)
                {

                    if (subCate.Checked)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e290de2b44aef61c551fd294d5e232b0b137818517", async() => {
                WriteLiteral("\n                            ");
#nullable restore
#line 122 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                       Write(subCate.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                            WriteLiteral(ViewBag.CateID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 124 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e290de2b44aef61c551fd294d5e232b0b1378111564", async() => {
                WriteLiteral("\n                            ");
#nullable restore
#line 128 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                       Write(subCate.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                         WriteLiteral(ViewBag.CateID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                                                         WriteLiteral(subCate.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["key"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-key", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["key"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 130 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br />\n");
#nullable restore
#line 132 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </td>\n        <td>\n            <div class=\"content\">\n");
#nullable restore
#line 137 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                 if (Model.ListProducts.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"text-align:center;width:600px\">Empty</p>\n");
#nullable restore
#line 140 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"container\">\n                        <div class=\"row\">\n");
#nullable restore
#line 145 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                             foreach (var product in Model.ListProducts)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e290de2b44aef61c551fd294d5e232b0b1378116533", async() => {
                WriteLiteral("\n\n                                <div class=\"col-md-3\">\n");
#nullable restore
#line 150 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                     foreach (var line in product.ListProductLines)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                         foreach (var image in line.ListImages)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div class=\"thumbnail\">\n                                                <img");
                BeginWriteAttribute("src", " src=\"", 4202, "\"", 4224, 1);
#nullable restore
#line 155 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 4208, image.Image_Url, 4208, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"content__productimage thumbnail__image\"");
                BeginWriteAttribute("id", " id=\"", 4272, "\"", 4301, 2);
                WriteAttributeValue("", 4277, "presentImage+", 4277, 13, true);
#nullable restore
#line 155 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 4290, product.ID, 4290, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                                <div class=""thumbnail__content"">
                                                    <a>View more</a>
                                                </div>
                                            </div>
");
#nullable restore
#line 160 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                            break;
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                         
                                        break;
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                      
                                        int lineCount = 0;
                                        foreach (var line in product.ListProductLines)
                                        {


                                            if (lineCount < 6)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <img");
                BeginWriteAttribute("src", " src=\"", 5130, "\"", 5159, 1);
#nullable restore
#line 172 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 5136, line.Texture_Image_Url, 5136, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"line-image\" class=\"content__textureimage\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5207, "\"", 5271, 5);
                WriteAttributeValue("", 5217, "ChangeImage(", 5217, 12, true);
#nullable restore
#line 172 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 5229, line.ListImages[0].Image_Url, 5229, 29, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5258, ",", 5258, 1, true);
#nullable restore
#line 172 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 5259, product.ID, 5259, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5270, ")", 5270, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\n");
#nullable restore
#line 173 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                lineCount++;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <table>\n                                        <tr>\n                                            <td><p>");
#nullable restore
#line 183 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                              Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\n                                            <td>\n");
#nullable restore
#line 185 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                 if (product.SalePrice != product.Price)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <p class=\"content__price\"><span style=\"text-decoration:line-through;font-size:small\">$");
#nullable restore
#line 187 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                                                                                     Write(product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> $");
#nullable restore
#line 187 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                                                                                                            Write(product.SalePrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 188 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <p class=\"content__price\">$");
#nullable restore
#line 191 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                          Write(product.SalePrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 192 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                            </td>\n                                        </tr>\n                                    </table>\n                                </div>\n\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 147 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                               WriteLiteral(product.ID);

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
            WriteLiteral("\n");
#nullable restore
#line 200 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n\n\n                        <a href=\"#\" class=\"content__more\">View more ...</a>\n                    </div>\n");
#nullable restore
#line 206 "D:\.CanDelete\Git\Lulus-master\Lulus.CustomerApp\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            </div>\n        </td>\n    </tr>\n</table>\n<script>\n    function ChangeImage(url, id) {\n        document.getElementById(\"presentImage\" + id).src = url;\n    }\n</script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lulus.CustomerApp.Models.Products.ProductCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
