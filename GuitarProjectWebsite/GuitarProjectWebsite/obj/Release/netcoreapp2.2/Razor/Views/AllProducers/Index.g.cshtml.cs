#pragma checksum "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be49ce06ed92938861552d9a76e23262a42229b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AllProducers_Index), @"mvc.1.0.view", @"/Views/AllProducers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AllProducers/Index.cshtml", typeof(AspNetCore.Views_AllProducers_Index))]
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
#line 2 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Index.cshtml"
using GuitarProjectWebsite.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be49ce06ed92938861552d9a76e23262a42229b5", @"/Views/AllProducers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3de29a78b29edff65565f2c05b50ebe718b5805", @"/Views/_ViewImports.cshtml")]
    public class Views_AllProducers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GuitarProjectWebsite.Models.Producer>>
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
        private global::BSolutions.Bocons.Controls.ListGroup.ListGroupTagHelper __BSolutions_Bocons_Controls_ListGroup_ListGroupTagHelper;
        private global::BSolutions.Bocons.Controls.ListGroup.ListGroupItemTagHelper __BSolutions_Bocons_Controls_ListGroup_ListGroupItemTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(107, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(150, 24, true);
            WriteLiteral("\r\n<h1>Producers</h1>\r\n\r\n");
            EndContext();
            BeginContext(174, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("list-group", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be49ce06ed92938861552d9a76e23262a42229b54362", async() => {
                BeginContext(186, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
                BeginContext(229, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(237, 137, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("list-group-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be49ce06ed92938861552d9a76e23262a42229b55056", async() => {
                    BeginContext(254, 43, true);
                    WriteLiteral("\r\n            <a class=\"nav-link text-dark\"");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 297, "\"", 330, 2);
                    WriteAttributeValue("", 304, "AllProducers/Show/", 304, 18, true);
#line 14 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Index.cshtml"
WriteAttributeValue("", 322, item.ID, 322, 8, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(331, 1, true);
                    WriteLiteral(">");
                    EndContext();
                    BeginContext(333, 9, false);
#line 14 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Index.cshtml"
                                                                       Write(item.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(342, 14, true);
                    WriteLiteral("</a>\r\n        ");
                    EndContext();
                }
                );
                __BSolutions_Bocons_Controls_ListGroup_ListGroupItemTagHelper = CreateTagHelper<global::BSolutions.Bocons.Controls.ListGroup.ListGroupItemTagHelper>();
                __tagHelperExecutionContext.Add(__BSolutions_Bocons_Controls_ListGroup_ListGroupItemTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(374, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Index.cshtml"
    }

#line default
#line hidden
            }
            );
            __BSolutions_Bocons_Controls_ListGroup_ListGroupTagHelper = CreateTagHelper<global::BSolutions.Bocons.Controls.ListGroup.ListGroupTagHelper>();
            __tagHelperExecutionContext.Add(__BSolutions_Bocons_Controls_ListGroup_ListGroupTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(396, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GuitarProjectWebsite.Models.Producer>> Html { get; private set; }
    }
}
#pragma warning restore 1591