#pragma checksum "/Users/taylorbennett/dev/ConferencePlanner/FrontEnd/Pages/Speaker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b136ffd8fe5858101d58d91cb6c261bcbe1bbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Pages_Speaker), @"mvc.1.0.razor-page", @"/Pages/Speaker.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Speaker.cshtml", typeof(FrontEnd.Pages.Pages_Speaker), @"{id}")]
namespace FrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/taylorbennett/dev/ConferencePlanner/FrontEnd/Pages/_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b136ffd8fe5858101d58d91cb6c261bcbe1bbb", @"/Pages/Speaker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a374d0d15cd4998cc4253f2a01ab7695a3d6cc4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Speaker : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Speakers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Session", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 59, true);
            WriteLiteral("\r\n<ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(94, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65b136ffd8fe5858101d58d91cb6c261bcbe1bbb3740", async() => {
                BeginContext(118, 8, true);
                WriteLiteral("Speakers");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(130, 46, true);
            WriteLiteral("</li>\r\n    <li class=\"breadcrumb-item active\">");
            EndContext();
            BeginContext(177, 18, false);
#line 6 "/Users/taylorbennett/dev/ConferencePlanner/FrontEnd/Pages/Speaker.cshtml"
                                  Write(Model.Speaker.Name);

#line default
#line hidden
            EndContext();
            BeginContext(195, 20, true);
            WriteLiteral("</li>\r\n</ol>\r\n\r\n<h2>");
            EndContext();
            BeginContext(216, 18, false);
#line 9 "/Users/taylorbennett/dev/ConferencePlanner/FrontEnd/Pages/Speaker.cshtml"
Write(Model.Speaker.Name);

#line default
#line hidden
            EndContext();
            BeginContext(234, 12, true);
            WriteLiteral("</h2>\r\n\r\n<p>");
            EndContext();
            BeginContext(247, 17, false);
#line 11 "/Users/taylorbennett/dev/ConferencePlanner/FrontEnd/Pages/Speaker.cshtml"
Write(Model.Speaker.Bio);

#line default
#line hidden
            EndContext();
            BeginContext(264, 107, true);
            WriteLiteral("</p>\r\n\r\n<h3>Sessions</h3>\r\n<div class=\"row\">\r\n    <div class=\"col-md-5\">\r\n        <ul class=\"list-group\">\r\n");
            EndContext();
#line 17 "/Users/taylorbennett/dev/ConferencePlanner/FrontEnd/Pages/Speaker.cshtml"
             foreach (var session in Model.Speaker.Sessions)
            {

#line default
#line hidden
            BeginContext(448, 44, true);
            WriteLiteral("                <li class=\"list-group-item\">");
            EndContext();
            BeginContext(492, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65b136ffd8fe5858101d58d91cb6c261bcbe1bbb6577", async() => {
                BeginContext(542, 13, false);
#line 19 "/Users/taylorbennett/dev/ConferencePlanner/FrontEnd/Pages/Speaker.cshtml"
                                                                                        Write(session.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "/Users/taylorbennett/dev/ConferencePlanner/FrontEnd/Pages/Speaker.cshtml"
                                                                    WriteLiteral(session.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(559, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 20 "/Users/taylorbennett/dev/ConferencePlanner/FrontEnd/Pages/Speaker.cshtml"
            }

#line default
#line hidden
            BeginContext(581, 33, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpeakerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SpeakerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SpeakerModel>)PageContext?.ViewData;
        public SpeakerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
