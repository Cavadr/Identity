#pragma checksum "C:\Users\cavad\OneDrive\Desktop\copy\Mvc-FrontToBack\FrontToBack\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63420c8d6860105f6d0acb04f66322d6f5a32cc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\cavad\OneDrive\Desktop\copy\Mvc-FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cavad\OneDrive\Desktop\copy\Mvc-FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.HomeModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63420c8d6860105f6d0acb04f66322d6f5a32cc0", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a12132f8e0fd48fc96913b6e147c04a6892110f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 238px;height: 30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("/product/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BasketController", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<header>
    <ul id=""search-list"">
        <li>
            <input type=""search"" id=""site-search"" name=""q""
                   aria-label=""Search through site content"">
            <button>Search</button>
        </li>


    </ul>

    <nav>
        <!-- <div class=""responsivNavbar-Icon""></div> -->
        <!-- <i class=""fas fa-bars""></i> -->
        <div class=""menu__bar"">
            <div class=""headTitle"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63420c8d6860105f6d0acb04f66322d6f5a32cc06420", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63420c8d6860105f6d0acb04f66322d6f5a32cc06636", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 549, "~/img/", 549, 6, true);
#nullable restore
#line 20 "C:\Users\cavad\OneDrive\Desktop\copy\Mvc-FrontToBack\FrontToBack\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 555, Model.LogoUrl, 555, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

            <div class=""navlink"">
                <ul>
                    <li>
                        <span class=""span1"">HOME</span>

                        <div class=""dropdown__menu"">
                            <ul>
                                <li><a href=""#"">Main Home</a></li>
                                <li><a href=""#"">Grid Home</a></li>
                                <li><a href=""#"">Flower Shop</a></li>
                                <li><a href=""#"">Metro Showcase</a></li>
                                <li><a href=""#"">Carousel Showcase</a></li>
                                <li><a href=""#"">Landing</a></li>
                            </ul>
                        </div>

                    </li>
                    <li>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1405, "\"", 1412, 0);
            EndWriteAttribute();
            WriteLiteral(@">PAGES</a>

                        <div class=""dropdown__menu"">
                            <ul>
                                <li><a href=""#"">About Us</a></li>
                                <li><a href=""#"">FAQ Page</a></li>
                                <li><a href=""#"">Contact Us</a></li>

                            </ul>
                        </div>

                    </li>
                    <li>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1868, "\"", 1875, 0);
            EndWriteAttribute();
            WriteLiteral(@">SHOP</a>
                        <div class=""dropdown__menu1"">
                            <div class=""flexforUl"">
                                <ul class=""ulS1"">
                                    <li><div class=""Shop-Title""><span>Product Types</span></div></li>
                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63420c8d6860105f6d0acb04f66322d6f5a32cc011350", async() => {
                WriteLiteral("Standard Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                                    <li><a href=""#"">Grouped Product</a></li>
                                    <li><a href=""#"">Variable Product</a></li>
                                    <li><a href=""#"">Virtual Product</a></li>
                                    <li><a href=""#"">External Product</a></li>
                                    <li><a href=""#"">Downloadable Product</a></li>
                                    <li><a href=""#"">On Sale Product</a></li>
                                    <li><a href=""#"">Out Of Stock Product</a></li>
                                    <li><a href=""#"">New Product</a></li>
                                </ul>

                                <ul class=""ulS2"">
                                    <li><div class=""Shop-Title""><span>Shop Pages</span></div></li>
                                    <li><a href=""#"">My Account</a></li>
                                    <li><a href=""#"">Cart</a></li>
                                    <li><a href=""#"">C");
            WriteLiteral(@"heckout</a></li>
                                    <li><a href=""#"">Orders</a></li>
                                    <li><a href=""#"">Downloads</a></li>
                                </ul>
                                <ul class=""ulS3"">
                                    <li><div class=""Shop-Title""><span>Shop Types</span></div></li>
                                    <li><a href=""#"">Product List</a></li>
                                    <li><a href=""#"">Without Sidebar</a></li>
                                    <li><a href=""#"">With Category Filter</a></li>
                                    <li><a href=""#"">With Ordering Filter</a></li>
                                    <li><a href=""#"">Shop Carousel</a></li>
                                    <li><a href=""#"">Product Categories</a></li>
                                    <li><a href=""#"">Single Category</a></li>
                                </ul>

                                <ul class=""ulS4"">
                             ");
            WriteLiteral(@"       <li><div class=""Shop-Title""><span>Shop Layout</span></div></li>
                                    <li><a href=""#"">Two Columns Grid</a></li>
                                    <li><a href=""#"">Three Columns Grid</a></li>
                                    <li><a href=""#"">Four Columns Grid</a></li>
                                    <li><a href=""#"">Four Columns Wide</a></li>
                                    <li><a href=""#"">Five Columns Wide</a></li>
                                    <li><a href=""#"">Six Columns Wide</a></li>
                                </ul>
                            </div>





                        </div>
                    </li>
                    <li>
                        <a");
            BeginWriteAttribute("href", " href=\"", 5054, "\"", 5061, 0);
            EndWriteAttribute();
            WriteLiteral(@">PORTFOLIO</a>
                        <div class=""dropdown__menu"">
                            <ul>
                                <li><a href=""#"">Standard</a></li>
                                <li><a href=""#"">Gallery</a></li>
                                <li><a href=""#"">Masonry</a></li>
                                <li>
                                    <a href=""#"">Portfolio Layouts</a>
                                </li>
                                <i class=""fas fasP fa-chevron-right""></i>

                                <li>
                                    <a href=""#"">Portfolio Single</a><i class=""fas fasDMPS fa-chevron-right""></i>

                                    <div class=""sub__menu"">
                                        <ul>
                                            <li><a href=""#"">Small Images</a></li>
                                            <li><a href=""#"">Small Slider</a></li>
                                            <li><a href=""#"">Big Image");
            WriteLiteral(@"s</a></li>
                                            <li><a href=""#"">Big Slider</a></li>
                                            <li><a href=""#"">Gallery</a></li>
                                        </ul>
                                    </div>


                                </li>
                            </ul>
                        </div>
                    </li>
                    <li>
                        <a");
            BeginWriteAttribute("href", " href=\"", 6537, "\"", 6544, 0);
            EndWriteAttribute();
            WriteLiteral(@">BLOG</a>
                        <div class=""dropdown__menu"">
                            <ul>
                                <li><a href=""#"">Masonry</a></li>
                                <li><a href=""#"">Standard</a></li>
                                <li>
                                    <a href=""#"">Post Types</a>  <i class=""fas fasB fa-chevron-right""></i>

                                    <div class=""sub__menu"">
                                        <ul>
                                            <li><a href=""#"">Standard</a></li>
                                            <li><a href=""#"">Gallery</a></li>
                                            <li><a href=""#"">Link</a></li>
                                            <li><a href=""#"">Quote</a></li>
                                            <li><a href=""#"">Audio</a></li>
                                            <li><a href=""#"">Video</a></li>
                                        </ul>
                               ");
            WriteLiteral("     </div>\r\n\r\n                                </li>\r\n\r\n                            </ul>\r\n                        </div>\r\n                    </li>\r\n                    <li>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 7773, "\"", 7780, 0);
            EndWriteAttribute();
            WriteLiteral(@">ELEMENTS</a>
                        <div class=""dropdown__menu"">
                            <ul>
                                <li style=""padding-bottom: 14px;"">
                                    <a href=""#"">Classic</a><i class=""fas fasE fa-chevron-right""></i>

                                    <div class=""sub__menu"">
                                        <ul>
                                            <li><a href=""#"">Accordions</a></li>
                                            <li><a href=""#"">Tabs</a></li>
                                            <li><a href=""#"">Buttons</a></li>
                                            <li><a href=""#"">Video Button</a></li>
                                            <li><a href=""#"">Contact Form</a></li>
                                        </ul>
                                    </div>
                                </li>


                                <li style=""padding-bottom: 13px;"">
                                    <a h");
            WriteLiteral(@"ref=""#"">Infographic</a><i class=""fas fasE fa-chevron-right""></i>

                                    <div class=""sub__menu"">
                                        <ul>
                                            <li><a href=""#"">Blog List</a></li>
                                            <li><a href=""#"">Counters</a></li>
                                            <li><a href=""#"">Countdown</a></li>
                                            <li><a href=""#"">Google Maps</a></li>
                                            <li><a href=""#"">Progress Bar</a></li>
                                            <li><a href=""#"">Pie Charts</a></li>
                                        </ul>
                                    </div>


                                </li>
                                <li style=""padding-bottom: 13px;"">
                                    <a href=""#"">Interactive</a><i class=""fas fasE fa-chevron-right""></i>

                                    <div class=""sub__m");
            WriteLiteral(@"enu"">
                                        <ul>
                                            <li><a href=""#"">Image Gallery</a></li>
                                            <li><a href=""#"">Testimonials</a></li>
                                            <li><a href=""#"">Team</a></li>
                                            <li><a href=""#"">Banner</a></li>
                                            <li><a href=""#"">Shop List</a></li>
                                            <li><a href=""#"">Portfolio List</a></li>
                                        </ul>
                                    </div>

                                </li>

                                <li style=""padding-bottom: 13px;"">
                                    <a href=""#"">Typography</a><i class=""fas fasE fa-chevron-right""></i>

                                    <div class=""sub__menu"">
                                        <ul>
                                            <li><a href=""#"">Headings</a");
            WriteLiteral(@"></li>
                                            <li><a href=""#"">Columns</a></li>
                                            <li><a href=""#"">Section Title</a></li>
                                            <li><a href=""#"">Blockquote</a></li>
                                            <li><a href=""#"">Dropcaps</a></li>
                                            <li><a href=""#"">Highlights</a></li>
                                            <li><a href=""#"">Separators</a></li>
                                            <li><a href=""#"">Custom Font</a></li>
                                        </ul>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </li>
                </ul>
            </div>

            <div class=""servicies"">
                <div class=""searchButton"">
                    <i class=""fas fa-search""></i>
                </div>

                <div cl");
            WriteLiteral("ass=\"shoppingBag\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63420c8d6860105f6d0acb04f66322d6f5a32cc023139", async() => {
                WriteLiteral("<i class=\"fas fa-shopping-bag\"</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <sup>\r\n                        ");
#nullable restore
#line 243 "C:\Users\cavad\OneDrive\Desktop\copy\Mvc-FrontToBack\FrontToBack\Views\Shared\Components\Header\Default.cshtml"
                   Write(ViewBag.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </sup>\r\n                </div>\r\n\r\n                <div class=\"cardSide\">\r\n                    <span>CART ($0)</span>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </nav>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
