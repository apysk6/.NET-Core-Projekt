#pragma checksum "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\Shared\_CreateButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eafe243b88a121103b11959f00e7efbcc438220"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CreateButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_CreateButtonPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CreateButtonPartial.cshtml", typeof(AspNetCore.Views_Shared__CreateButtonPartial))]
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
#line 1 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\_ViewImports.cshtml"
using GuitarProjectWebsite;

#line default
#line hidden
#line 2 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\_ViewImports.cshtml"
using GuitarProjectWebsite.Models;

#line default
#line hidden
#line 3 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\_ViewImports.cshtml"
using BSolutions.Bocons.Enumerations;

#line default
#line hidden
#line 4 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\_ViewImports.cshtml"
using BSolutions.Brecons.Core.Enumerations;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eafe243b88a121103b11959f00e7efbcc438220", @"/Views/Shared/_CreateButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3de29a78b29edff65565f2c05b50ebe718b5805", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CreateButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 59, true);
            WriteLiteral("<a type=\"button\" class=\"btn btn-primary btn-sm btn-success\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n   href=\"", 59, "\"", 91, 1);
#line 2 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\Shared\_CreateButtonPartial.cshtml"
WriteAttributeValue("", 70, Url.Action("Create"), 70, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(92, 84, true);
            WriteLiteral(">\r\n    <span class=\"glyphicon glyphicon-list\"></span>\r\n    <span>Create</span>\r\n</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
