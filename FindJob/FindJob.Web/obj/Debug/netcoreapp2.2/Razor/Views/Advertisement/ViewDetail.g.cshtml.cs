#pragma checksum "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Advertisement\ViewDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfca12551d682a74d6b61c6cb8ec0d5f3240293a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advertisement_ViewDetail), @"mvc.1.0.view", @"/Views/Advertisement/ViewDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Advertisement/ViewDetail.cshtml", typeof(AspNetCore.Views_Advertisement_ViewDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfca12551d682a74d6b61c6cb8ec0d5f3240293a", @"/Views/Advertisement/ViewDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28776fbe7c15f03107e2b26a42436832e14b5b2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Advertisement_ViewDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindJob.Web.Models.AdvertisementViewModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Advertisement\ViewDetail.cshtml"
   
    Layout = "~/Views/Advertisement/AdvertisementLayout.cshtml";

#line default
#line hidden
            BeginContext(127, 18, true);
            WriteLiteral("\r\n    <html>\r\n    ");
            EndContext();
            BeginContext(145, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfca12551d682a74d6b61c6cb8ec0d5f3240293a3498", async() => {
                BeginContext(151, 102, true);
                WriteLiteral("\r\n        <meta name=\"viewport\" content=\"width=device-width\" />\r\n        <h4>İlan Detayları</h4>\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(260, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(266, 1773, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfca12551d682a74d6b61c6cb8ec0d5f3240293a4794", async() => {
                BeginContext(272, 687, true);
                WriteLiteral(@"
        <div class=""col-md-10"">

            <style>
                .btn {
                    border: none;
                    color: white;
                    padding: 7px 9px;
                    font-size: 16px;
                    cursor: pointer;
                }

                .info {
                    background-color: #2196F3;
                }

                .danger {
                    background-color: #f44336;
                }
                    /* Red */
                    .danger:hover {
                        background: #da190b;
                    }
            </style>

            <ul>
                <li>İlan Adı <a>");
                EndContext();
                BeginContext(960, 24, false);
#line 38 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Advertisement\ViewDetail.cshtml"
                           Write(Model.Advertisement.Name);

#line default
#line hidden
                EndContext();
                BeginContext(984, 44, true);
                WriteLiteral("</a> </li>\r\n                <li>Firma Adı<a>");
                EndContext();
                BeginContext(1029, 33, false);
#line 39 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Advertisement\ViewDetail.cshtml"
                           Write(Model.Advertisement.Company?.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1062, 44, true);
                WriteLiteral("</a> </li>\r\n                <li> Sektör  <a>");
                EndContext();
                BeginContext(1107, 32, false);
#line 40 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Advertisement\ViewDetail.cshtml"
                           Write(Model.Advertisement.Sector?.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1139, 45, true);
                WriteLiteral("</a>  </li>\r\n                <li> Meslek  <a>");
                EndContext();
                BeginContext(1185, 29, false);
#line 41 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Advertisement\ViewDetail.cshtml"
                           Write(Model.Advertisement.Job?.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1214, 49, true);
                WriteLiteral("</a>  </li>\r\n                <li>Eğitim Durum <a>");
                EndContext();
                BeginContext(1264, 35, false);
#line 42 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Advertisement\ViewDetail.cshtml"
                               Write(Model.Advertisement.Education?.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1299, 53, true);
                WriteLiteral("</a> </li>\r\n                <li> Cinsiyet Tercihi <a>");
                EndContext();
                BeginContext(1353, 32, false);
#line 43 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Advertisement\ViewDetail.cshtml"
                                    Write(Model.Advertisement.Gender?.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1385, 53, true);
                WriteLiteral("</a></li>\r\n                <li> Çalışma Pozisyonu <a>");
                EndContext();
                BeginContext(1439, 31, false);
#line 44 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Advertisement\ViewDetail.cshtml"
                                     Write(Model.Advertisement.Level?.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1470, 48, true);
                WriteLiteral("</a></li>\r\n                <li>Çalışma Zamanı<a>");
                EndContext();
                BeginContext(1519, 37, false);
#line 45 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Advertisement\ViewDetail.cshtml"
                                Write(Model.Advertisement.WorkingTime?.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1556, 476, true);
                WriteLiteral(@"</a></li>
            </ul>
            <ul>

                <li>
                    <!--Çalışmıyor-->
                    <a class="" btn btn-xs btn danger"" href=""https://localhost:44388/Account/Login"" style="" border: none;
                        color: white;
                        padding: 7px 10px;
                        font-size: 16px;
                        cursor: pointer;"">BAŞVUR</a>
                </li>

            </ul>
        </div>
    ");
                EndContext();
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
            EndContext();
            BeginContext(2039, 13, true);
            WriteLiteral("\r\n    </html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindJob.Web.Models.AdvertisementViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591