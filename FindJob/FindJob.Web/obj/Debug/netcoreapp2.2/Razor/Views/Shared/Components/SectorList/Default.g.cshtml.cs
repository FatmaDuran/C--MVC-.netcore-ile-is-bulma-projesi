#pragma checksum "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\SectorList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd4e57ea92ee51471b8a13fe3382a1588e8a7d29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SectorList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SectorList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SectorList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_SectorList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd4e57ea92ee51471b8a13fe3382a1588e8a7d29", @"/Views/Shared/Components/SectorList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28776fbe7c15f03107e2b26a42436832e14b5b2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SectorList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindJob.Web.Models.SectorListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 53, true);
            WriteLiteral("\r\n    <div class=\"list-group\">\r\n\r\n        <table>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\SectorList\Default.cshtml"
             foreach (var Sector in Model.Sectors)
            {

#line default
#line hidden
            BeginContext(167, 74, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 241, "\"", 295, 2);
            WriteAttributeValue("", 248, "/Advertisement/FilterBySector?sector=", 248, 37, true);
#line 11 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\SectorList\Default.cshtml"
WriteAttributeValue("", 285, Sector.Id, 285, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(296, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(298, 11, false);
#line 11 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\SectorList\Default.cshtml"
                                                                             Write(Sector.Name);

#line default
#line hidden
            EndContext();
            BeginContext(309, 56, true);
            WriteLiteral("</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 14 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\SectorList\Default.cshtml"

            }

#line default
#line hidden
            BeginContext(382, 34, true);
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindJob.Web.Models.SectorListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
