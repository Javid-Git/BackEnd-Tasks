#pragma checksum "C:\Users\user\source\repos\Front-To-Back-practice\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34b26ba6dffc35ef352c015703c7355b4ed032c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 2 "C:\Users\user\source\repos\Front-To-Back-practice\Views\_ViewImports.cshtml"
using Front_To_Back_practice.ViewModels.PricingViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\Front-To-Back-practice\Views\_ViewImports.cshtml"
using Front_To_Back_practice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34b26ba6dffc35ef352c015703c7355b4ed032c9", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bc516a84528c1c256ed38a9efacb2a89241520c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link scrollto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "about", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link scrollto "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "portfolio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "pricing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "team", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b26ba6dffc35ef352c015703c7355b4ed032c96904", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\r\n\r\n    <title>Day Bootstrap Template - Index</title>\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 211, "\"", 221, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"description\">\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 253, "\"", 263, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""keywords"">

    <!-- Favicons -->
    <link href=""assets/img/favicon.png"" rel=""icon"">
    <link href=""assets/img/apple-touch-icon.png"" rel=""apple-touch-icon"">

    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Raleway:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i"" rel=""stylesheet"">

    <!-- Vendor CSS Files -->
    <link href=""assets/vendor/aos/aos.css"" rel=""stylesheet"">
    <link href=""assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/bootstrap-icons/bootstrap-icons.css"" rel=""stylesheet"">
    <link href=""assets/vendor/boxicons/css/boxicons.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/glightbox/css/glightbox.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/swiper/swiper-bundle.min.css"" rel=""stylesheet"">

    <!-- Template Main CSS File -->
    <link href=""assets/css/style.css"" rel=""stylesheet");
                WriteLiteral(@""">

    <!-- =======================================================
    * Template Name: Day - v4.7.0
    * Template URL: https://bootstrapmade.com/day-multipurpose-html-template-for-free/
    * Author: BootstrapMade.com
    * License: https://bootstrapmade.com/license/
    ======================================================== -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b26ba6dffc35ef352c015703c7355b4ed032c99849", async() => {
                WriteLiteral(@"

    <!-- ======= Top Bar ======= -->
    <section id=""topbar"" class=""d-flex align-items-center"">
        <div class=""container d-flex justify-content-center justify-content-md-between"">
            <div class=""contact-info d-flex align-items-center"">
                <i class=""bi bi-envelope-fill""></i><a href=""mailto:contact@example.com"">info@example.com</a>
                <i class=""bi bi-phone-fill phone-icon""></i> +1 5589 55488 55
            </div>
            <div class=""social-links d-none d-md-block"">
                <a href=""#"" class=""twitter""><i class=""bi bi-twitter""></i></a>
                <a href=""#"" class=""facebook""><i class=""bi bi-facebook""></i></a>
                <a href=""#"" class=""instagram""><i class=""bi bi-instagram""></i></a>
                <a href=""#"" class=""linkedin""><i class=""bi bi-linkedin""></i></a>
            </div>
        </div>
    </section>

    <!-- ======= Header ======= -->
    <header id=""header"" class=""d-flex align-items-center"">
        <div class=""cont");
                WriteLiteral(@"ainer d-flex align-items-center justify-content-between"">

            <h1 class=""logo""><a href=""index.html"">Day</a></h1>
            <!-- Uncomment below if you prefer to use an image logo -->
            <!-- <a href=""index.html"" class=""logo""><img src=""assets/img/logo.png"" alt="""" class=""img-fluid""></a>-->

            <nav id=""navbar"" class=""navbar"">
                <ul>
                    <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b26ba6dffc35ef352c015703c7355b4ed032c911636", async() => {
                    WriteLiteral("About");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                    <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b26ba6dffc35ef352c015703c7355b4ed032c913185", async() => {
                    WriteLiteral("Services");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                    <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b26ba6dffc35ef352c015703c7355b4ed032c914737", async() => {
                    WriteLiteral("Portfolio");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                    <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b26ba6dffc35ef352c015703c7355b4ed032c916290", async() => {
                    WriteLiteral("Pricing");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                    <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b26ba6dffc35ef352c015703c7355b4ed032c917841", async() => {
                    WriteLiteral("Team");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                    <li class=""dropdown"">
                        <a href=""#""><span>Drop Down</span> <i class=""bi bi-chevron-down""></i></a>
                        <ul>
                            <li><a href=""#"">Drop Down 1</a></li>
                            <li class=""dropdown"">
                                <a href=""#""><span>Deep Drop Down</span> <i class=""bi bi-chevron-right""></i></a>
                                <ul>
                                    <li><a href=""#"">Deep Drop Down 1</a></li>
                                    <li><a href=""#"">Deep Drop Down 2</a></li>
                                    <li><a href=""#"">Deep Drop Down 3</a></li>
                                    <li><a href=""#"">Deep Drop Down 4</a></li>
                                    <li><a href=""#"">Deep Drop Down 5</a></li>
                                </ul>
                            </li>
                            <li><a href=""#"">Drop Down 2</a></li>
                            <li><a href=""#");
                WriteLiteral(@""">Drop Down 3</a></li>
                            <li><a href=""#"">Drop Down 4</a></li>
                        </ul>
                    </li>
                    <li><a class=""nav-link scrollto"" href=""#contact"">Contact</a></li>
                </ul>
                <i class=""bi bi-list mobile-nav-toggle""></i>
            </nav><!-- .navbar -->

        </div>
    </header><!-- End Header -->
    ");
#nullable restore
#line 97 "C:\Users\user\source\repos\Front-To-Back-practice\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
    <!-- ======= Clients Section ======= -->
    <section id=""clients"" class=""clients"">
        <div class=""container"" data-aos=""zoom-in"">

            <div class=""row d-flex align-items-center"">

                <div class=""col-lg-2 col-md-4 col-6"">
                    <img src=""assets/img/clients/client-1.png"" class=""img-fluid""");
                BeginWriteAttribute("alt", " alt=\"", 5413, "\"", 5419, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"col-lg-2 col-md-4 col-6\">\r\n                    <img src=\"assets/img/clients/client-2.png\" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 5584, "\"", 5590, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"col-lg-2 col-md-4 col-6\">\r\n                    <img src=\"assets/img/clients/client-3.png\" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 5755, "\"", 5761, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"col-lg-2 col-md-4 col-6\">\r\n                    <img src=\"assets/img/clients/client-4.png\" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 5926, "\"", 5932, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"col-lg-2 col-md-4 col-6\">\r\n                    <img src=\"assets/img/clients/client-5.png\" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 6097, "\"", 6103, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"col-lg-2 col-md-4 col-6\">\r\n                    <img src=\"assets/img/clients/client-6.png\" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 6268, "\"", 6274, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                </div>

            </div>

        </div>
    </section><!-- End Clients Section -->
    <!-- ======= Footer ======= -->
    <footer id=""footer"">
        <div class=""footer-top"">
            <div class=""container"">
                <div class=""row"">

                    <div class=""col-lg-4 col-md-6"">
                        <div class=""footer-info"">
                            <h3>Day</h3>
                            <p>
                                A108 Adam Street <br>
                                NY 535022, USA<br><br>
                                <strong>Phone:</strong> +1 5589 55488 55<br>
                                <strong>Email:</strong> info@example.com<br>
                            </p>
                            <div class=""social-links mt-3"">
                                <a href=""#"" class=""twitter""><i class=""bx bxl-twitter""></i></a>
                                <a href=""#"" class=""facebook""><i class=""bx bxl-facebook""></i></a>
       ");
                WriteLiteral(@"                         <a href=""#"" class=""instagram""><i class=""bx bxl-instagram""></i></a>
                                <a href=""#"" class=""google-plus""><i class=""bx bxl-skype""></i></a>
                                <a href=""#"" class=""linkedin""><i class=""bx bxl-linkedin""></i></a>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-2 col-md-6 footer-links"">
                        <h4>Useful Links</h4>
                        <ul>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Home</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">About us</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Services</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Terms of service</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Privacy policy");
                WriteLiteral(@"</a></li>
                        </ul>
                    </div>

                    <div class=""col-lg-2 col-md-6 footer-links"">
                        <h4>Our Services</h4>
                        <ul>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Web Design</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Web Development</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Product Management</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Marketing</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Graphic Design</a></li>
                        </ul>
                    </div>

                    <div class=""col-lg-4 col-md-6 footer-newsletter"">
                        <h4>Our Newsletter</h4>
                        <p>Tamen quem nulla quae legam multos aute sint culpa legam noster magna</p>
     ");
                WriteLiteral("                   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34b26ba6dffc35ef352c015703c7355b4ed032c926518", async() => {
                    WriteLiteral("\r\n                            <input type=\"email\" name=\"email\"><input type=\"submit\" value=\"Subscribe\">\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
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
            </div>
        </div>

        <div class=""container"">
            <div class=""copyright"">
                &copy; Copyright <strong><span>Day</span></strong>. All Rights Reserved
            </div>
            <div class=""credits"">
                <!-- All the links in the footer should remain intact. -->
                <!-- You can delete the links only if you purchased the pro version. -->
                <!-- Licensing information: https://bootstrapmade.com/license/ -->
                <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/day-multipurpose-html-template-for-free/ -->
                Designed by <a href=""https://bootstrapmade.com/"">BootstrapMade</a>
            </div>
        </div>
    </footer><!-- End Footer -->

    <a href=""#"" class=""back-to-top d-flex align-items-center justify-content-center""><i class=""bi bi-arrow-up-short""></i></a>
    <div id=""preloader""></d");
                WriteLiteral(@"iv>

    <!-- Vendor JS Files -->
    <script src=""assets/vendor/aos/aos.js""></script>
    <script src=""assets/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/vendor/glightbox/js/glightbox.min.js""></script>
    <script src=""assets/vendor/isotope-layout/isotope.pkgd.min.js""></script>
    <script src=""assets/vendor/swiper/swiper-bundle.min.js""></script>
    <script src=""assets/vendor/php-email-form/validate.js""></script>

    <!-- Template Main JS File -->
    <script src=""assets/js/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
