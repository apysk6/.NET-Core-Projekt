#pragma checksum "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f99acfc7617e7789146bee24bca3b89f146d55c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AllProducers_Show), @"mvc.1.0.view", @"/Views/AllProducers/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AllProducers/Show.cshtml", typeof(AspNetCore.Views_AllProducers_Show))]
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
#line 2 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
using GuitarProjectWebsite.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f99acfc7617e7789146bee24bca3b89f146d55c2", @"/Views/AllProducers/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3de29a78b29edff65565f2c05b50ebe718b5805", @"/Views/_ViewImports.cshtml")]
    public class Views_AllProducers_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GuitarProjectWebsite.Models.GuitarViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::GuitarProjectWebsite.TagHelpers.IfTagHelper __GuitarProjectWebsite_TagHelpers_IfTagHelper;
        private global::BSolutions.Bocons.Controls.Card.CardTagHelper __BSolutions_Bocons_Controls_Card_CardTagHelper;
        private global::BSolutions.Bocons.Controls.Card.CardImageTagHelper __BSolutions_Bocons_Controls_Card_CardImageTagHelper;
        private global::BSolutions.Bocons.Controls.Card.CardBodyTagHelper __BSolutions_Bocons_Controls_Card_CardBodyTagHelper;
        private global::BSolutions.Bocons.Controls.Buttons.ButtonTagHelper __BSolutions_Bocons_Controls_Buttons_ButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
  
    ViewData["Title"] = "Show";

#line default
#line hidden
            BeginContext(156, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(158, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("h1", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99acfc7617e7789146bee24bca3b89f146d55c25371", async() => {
                BeginContext(194, 22, false);
#line 8 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
                              Write(Model.First().Category);

#line default
#line hidden
                EndContext();
            }
            );
            __GuitarProjectWebsite_TagHelpers_IfTagHelper = CreateTagHelper<global::GuitarProjectWebsite.TagHelpers.IfTagHelper>();
            __tagHelperExecutionContext.Add(__GuitarProjectWebsite_TagHelpers_IfTagHelper);
#line 8 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
__GuitarProjectWebsite_TagHelpers_IfTagHelper.Predicate = Model.ToList().Any();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-if", __GuitarProjectWebsite_TagHelpers_IfTagHelper.Predicate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(221, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(258, 355, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99acfc7617e7789146bee24bca3b89f146d55c27305", async() => {
                BeginContext(285, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(291, 121, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card-image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f99acfc7617e7789146bee24bca3b89f146d55c27691", async() => {
                }
                );
                __BSolutions_Bocons_Controls_Card_CardImageTagHelper = CreateTagHelper<global::BSolutions.Bocons.Controls.Card.CardImageTagHelper>();
                __tagHelperExecutionContext.Add(__BSolutions_Bocons_Controls_Card_CardImageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                WriteLiteral("data:image/jpeg;base64,");
#line 13 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
                                                     WriteLiteral(Convert.ToBase64String(item.Image));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __BSolutions_Bocons_Controls_Card_CardImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __BSolutions_Bocons_Controls_Card_CardImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
__BSolutions_Bocons_Controls_Card_CardImageTagHelper.Position = global::BSolutions.Bocons.Enumerations.CardImagePosition.Bottom;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("bc-position", __BSolutions_Bocons_Controls_Card_CardImageTagHelper.Position, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(412, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(418, 186, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("card-body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99acfc7617e7789146bee24bca3b89f146d55c210163", async() => {
                    BeginContext(451, 27, true);
                    WriteLiteral("\r\n        <p>\r\n            ");
                    EndContext();
                    BeginContext(479, 16, false);
#line 16 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
       Write(item.Description);

#line default
#line hidden
                    EndContext();
                    BeginContext(495, 24, true);
                    WriteLiteral("\r\n        </p>\r\n        ");
                    EndContext();
                    BeginContext(519, 67, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99acfc7617e7789146bee24bca3b89f146d55c211014", async() => {
                        BeginContext(560, 22, true);
                        WriteLiteral("Visit producer website");
                        EndContext();
                    }
                    );
                    __BSolutions_Bocons_Controls_Buttons_ButtonTagHelper = CreateTagHelper<global::BSolutions.Bocons.Controls.Buttons.ButtonTagHelper>();
                    __tagHelperExecutionContext.Add(__BSolutions_Bocons_Controls_Buttons_ButtonTagHelper);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
AddHtmlAttributeValue("", 528, item.Website, 528, 13, false);

#line default
#line hidden
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#line 18 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
__BSolutions_Bocons_Controls_Buttons_ButtonTagHelper.Button = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("bc-button", __BSolutions_Bocons_Controls_Buttons_ButtonTagHelper.Button, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(586, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __BSolutions_Bocons_Controls_Card_CardBodyTagHelper = CreateTagHelper<global::BSolutions.Bocons.Controls.Card.CardBodyTagHelper>();
                __tagHelperExecutionContext.Add(__BSolutions_Bocons_Controls_Card_CardBodyTagHelper);
                BeginWriteTagHelperAttribute();
#line 14 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
             WriteLiteral(item.Name);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __BSolutions_Bocons_Controls_Card_CardBodyTagHelper.Title = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("bc-title", __BSolutions_Bocons_Controls_Card_CardBodyTagHelper.Title, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(604, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __BSolutions_Bocons_Controls_Card_CardTagHelper = CreateTagHelper<global::BSolutions.Bocons.Controls.Card.CardTagHelper>();
            __tagHelperExecutionContext.Add(__BSolutions_Bocons_Controls_Card_CardTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(613, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\Arthur\source\repos\GuitarProjectWebsite\GuitarProjectWebsite\Views\AllProducers\Show.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GuitarProjectWebsite.Models.GuitarViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
