#pragma checksum "C:\Users\Lekha Tiwari\Desktop\valsbeat\ValsBeatsLayout-main\ValsBeats\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff3b107273cc1c8ca05c6ee66ffb54d5b54fe64b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Lekha Tiwari\Desktop\valsbeat\ValsBeatsLayout-main\ValsBeats\Views\_ViewImports.cshtml"
using ValsBeats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lekha Tiwari\Desktop\valsbeat\ValsBeatsLayout-main\ValsBeats\Views\_ViewImports.cshtml"
using ValsBeats.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff3b107273cc1c8ca05c6ee66ffb54d5b54fe64b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f062e6ff0774806a92ffe96ff584824629990c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pic1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pic 2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Second slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pic3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Third slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lekha Tiwari\Desktop\valsbeat\ValsBeatsLayout-main\ValsBeats\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .cards-wrapper {
        display: flex;
        justify-content: center;
    }

    .card img {
        max-width: 100%;
        max-height: 100%;
    }

    .card {
        margin: 0 0.5em;
        box-shadow: 2px 6px 8px 0 rgba(22, 22, 26, 0.18);
        border: none;
        border-radius: 0;
    }

    .carousel-inner {
        padding: 1em;
    }

    .carousel-control-prev,
    .carousel-control-next {
        background-color: #e1e1e1;
        width: 5vh;
        height: 5vh;
        border-radius: 50%;
        top: 50%;
        transform: translateY(-50%);
    }
</style>
<div class=""abc"">
    <div class=""container"">
        <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                <li data-target=""#carouselExampleIndicators"" ");
            WriteLiteral("data-slide-to=\"2\"></li>\n            </ol>\n            <div class=\"carousel-inner\">\n                <div class=\"carousel-item active\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ff3b107273cc1c8ca05c6ee66ffb54d5b54fe64b7052", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <div class=\"carousel-item\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ff3b107273cc1c8ca05c6ee66ffb54d5b54fe64b8338", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <div class=\"carousel-item\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ff3b107273cc1c8ca05c6ee66ffb54d5b54fe64b9624", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
    <div class=""container"" id=""ab""><h1>Music </h1><h3>Trending</h3></div>
    <div id=""carouselTrending"" class=""carousel slide"" data-ride=""carousel"">
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <div class=""cards-wrapper"">
                    <div class=""card"">
                        <img src=""/images/img1.jpg"" class=""card-img-top"" alt=""img1"">
                       ");
            WriteLiteral(@" <div class=""card-body"">
                            <!-- <h5 class=""card-title"">Music 1</h5>-->
                            <a href=""#"">
                                <h5 class=""card-title"">Tere Bin</h5>
                            </a>
                        </div>
                    </div>
                    <div class=""card d-none d-md-block"">
                        <img src=""/images/img2.jpg"" class=""card-img-top"" alt=""..."">
                        <div class=""card-body"">
                            <a href=""#"">
                                <h5 class=""card-title"">Bin Tere</h5>
                            </a>

                        </div>
                    </div>
                    <div class=""card d-none d-md-block"">
                        <img src=""/images/img3.jpg"" class=""card-img-top"" alt=""..."">
                        <div class=""card-body"">
                            <a href=""#"">
                                <h5 class=""card-title"">Toofaan</h5>
                            </a>
    ");
            WriteLiteral(@"                    </div>
                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <div class=""cards-wrapper"">
                    <div class=""card"">
                        <img src=""/images/img4.jpg"" class=""card-img-top"" alt=""..."">
                        <div class=""card-body"">
                            <a href=""#"">
                                <h5 class=""card-title"">Dil Melt Krda</h5>
                            </a>
                        </div>
                    </div>
                    <div class=""card d-none d-md-block"">
                        <img src=""/images/img5.jpg"" class=""card-img-top"" alt=""..."">
                        <div class=""card-body"">
                            <a href=""#"">
                                <h5 class=""card-title"">Kailasa</h5>
                            </a>

                        </div>
                    </div>
                    <div class=""card d-none d-md-block"">
                    ");
            WriteLiteral(@"    <img src=""/images/img6.jpg"" class=""card-img-top"" alt=""..."">
                        <div class=""card-body"">
                            <a href=""#"">
                                <h5 class=""card-title"">Lut Gye</h5>
                            </a>

                        </div>
                    </div>
                </div>
            </div>

        </div>
        <a class=""carousel-control-prev"" href=""#carouselTrending"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselTrending"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
    <div class=""container"" id=""ab""><h3>New Release</h3></div>
    <div id=""carouselNewRelease"" class=""carousel slide"" data-ride=""carousel"">
        <div class=""ca");
            WriteLiteral(@"rousel-inner"">
            <div class=""carousel-item active"">
                <div class=""cards-wrapper"">
                    <div class=""card"">
                        <img src=""/images/img1.jpg"" class=""card-img-top"" alt=""img1"">
                        <div class=""card-body"">
                            <a href=""#"">
                                <h5 class=""card-title"">Tere Bin</h5>
                            </a>


                        </div>
                    </div>
                    <div class=""card d-none d-md-block"">
                        <img src=""/images/img2.jpg"" class=""card-img-top"" alt=""..."">
                        <div class=""card-body"">
                            <a href=""#"">
                                <h5 class=""card-title"">Bin Tere</h5>
                            </a>

                        </div>
                    </div>
                    <div class=""card d-none d-md-block"">
                        <img src=""/images/img3.jpg"" class=""card-img-top"" alt=""..."">
           ");
            WriteLiteral(@"             <div class=""card-body"">
                            <a href=""#"">
                                <h5 class=""card-title"">Toofan</h5>
                            </a>

                        </div>
                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <div class=""cards-wrapper"">
                    <div class=""card"">
                        <img src=""/images/img4.jpg"" class=""card-img-top"" alt=""..."">
                        <div class=""card-body"">
                            <a href=""#"">
                                <h5 class=""card-title"">Dil Melt Krda</h5>
                            </a>

                        </div>
                    </div>
                    <div class=""card d-none d-md-block"">
                        <img src=""/images/img5.jpg"" class=""card-img-top"" alt=""..."">
                        <div class=""card-body"">
                            <a href=""#"">
                                <h5 class=""card-title");
            WriteLiteral(@""">Kailasa</h5>
                            </a>

                        </div>
                    </div>
                    <div class=""card d-none d-md-block"">
                        <img src=""/images/img6.jpg"" class=""card-img-top"" alt=""..."">
                        <div class=""card-body"">
                            <a href=""#"">
                                <h5 class=""card-title"">Lut Gye</h5>
                            </a>

                        </div>
                    </div>
                </div>
            </div>

        </div>
        <a class=""carousel-control-prev"" href=""#carouselNewRelease"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselNewRelease"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span");
            WriteLiteral(@">
        </a>
    </div>
</div>
<style>
    .cards-wrapper {
        display: flex;
        justify-content: center;
    }

    .card img {
        max-width: 100%;
        max-height: 100%;
    }

    .card {
        margin: 0 0.5em;
        box-shadow: 2px 6px 8px 0 rgb(0,0,0);
        border: none;
        border-radius: 0;
    }

    .carousel-inner {
        padding: 1em;
    }

    .card-body {
        color: black;
    }

    .carousel-control-prev,
    .carousel-control-next {
        background-color: black;
        width: 5vh;
        height: 5vh;
        border-radius: 50%;
        top: 50%;
        transform: translateY(-50%);
    }

    .abc {
        background-image: url(""/images/background image.PNG"");
    }

    #ab {
        color: ghostwhite;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
