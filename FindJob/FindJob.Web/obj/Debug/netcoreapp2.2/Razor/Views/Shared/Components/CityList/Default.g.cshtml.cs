#pragma checksum "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\CityList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1871c15755273144b0833a6f7002cc4171bf0a49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CityList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CityList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CityList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CityList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1871c15755273144b0833a6f7002cc4171bf0a49", @"/Views/Shared/Components/CityList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28776fbe7c15f03107e2b26a42436832e14b5b2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CityList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindJob.Web.Models.CityListViewModel>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(47, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1871c15755273144b0833a6f7002cc4171bf0a493088", async() => {
                BeginContext(53, 68, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"Style.css\" />\r\n\r\n");
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
            BeginContext(128, 45, true);
            WriteLiteral("\r\n<div class=\"list-group\">\r\n\r\n\r\n    <table>\r\n");
            EndContext();
#line 11 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\CityList\Default.cshtml"
         foreach (var City in Model.Cities)
        {

#line default
#line hidden
            BeginContext(229, 62, true);
            WriteLiteral("            <ul>\r\n                <li>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 291, "\"", 340, 3);
            WriteAttributeValue("", 298, "/Advertisement/FilterByCity?city=", 298, 33, true);
#line 15 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\CityList\Default.cshtml"
WriteAttributeValue("", 331, City.Id, 331, 8, false);

#line default
#line hidden
            WriteAttributeValue(" ", 339, "", 340, 1, true);
            EndWriteAttribute();
            BeginContext(341, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(343, 9, false);
#line 15 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\CityList\Default.cshtml"
                                                                    Write(City.Name);

#line default
#line hidden
            EndContext();
            BeginContext(352, 50, true);
            WriteLiteral("</a>\r\n\r\n                </li>\r\n            </ul>\r\n");
            EndContext();
#line 19 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\CityList\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(413, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindJob.Web.Models.CityListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
