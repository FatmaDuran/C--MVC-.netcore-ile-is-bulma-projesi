#pragma checksum "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\JobList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd27ce608d97309a0080e59e00c6ca54f9f7a10b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_JobList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/JobList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/JobList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_JobList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd27ce608d97309a0080e59e00c6ca54f9f7a10b", @"/Views/Shared/Components/JobList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28776fbe7c15f03107e2b26a42436832e14b5b2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_JobList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindJob.Web.Models.JobListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(46, 51, true);
            WriteLiteral("\r\n    <div class=\"list-group\">\r\n\r\n        <table>\r\n");
            EndContext();
#line 7 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\JobList\Default.cshtml"
             foreach (var Job in Model.Jobs)
            {

#line default
#line hidden
            BeginContext(158, 76, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 234, "\"", 279, 2);
            WriteAttributeValue("", 241, "/Advertisement/FilterByJob?job=", 241, 31, true);
#line 12 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\JobList\Default.cshtml"
WriteAttributeValue("", 272, Job.Id, 272, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(280, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(282, 8, false);
#line 12 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\JobList\Default.cshtml"
                                                                    Write(Job.Name);

#line default
#line hidden
            EndContext();
            BeginContext(290, 56, true);
            WriteLiteral("</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 15 "C:\Users\Fatma Duran\Desktop\Projem2019\FindJob\FindJob.Web\Views\Shared\Components\JobList\Default.cshtml"
                

            }

#line default
#line hidden
            BeginContext(381, 32, true);
            WriteLiteral("        </table>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindJob.Web.Models.JobListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591