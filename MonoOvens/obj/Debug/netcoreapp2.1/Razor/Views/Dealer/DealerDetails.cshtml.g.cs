#pragma checksum "E:\Mono\MonoOvens\Views\Dealer\DealerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f67b148ed089081fb3dc5a0b679812215c252da0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dealer_DealerDetails), @"mvc.1.0.view", @"/Views/Dealer/DealerDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dealer/DealerDetails.cshtml", typeof(AspNetCore.Views_Dealer_DealerDetails))]
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
#line 1 "E:\Mono\MonoOvens\Views\_ViewImports.cshtml"
using MonoOvens;

#line default
#line hidden
#line 2 "E:\Mono\MonoOvens\Views\_ViewImports.cshtml"
using MonoOvens.Models;

#line default
#line hidden
#line 3 "E:\Mono\MonoOvens\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67b148ed089081fb3dc5a0b679812215c252da0", @"/Views/Dealer/DealerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583fb51fb58d48fb43f505eee7f8118d921845d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Dealer_DealerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MonoOvens.Models.DealerMaster>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditDealer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DealersList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Mono\MonoOvens\Views\Dealer\DealerDetails.cshtml"
  
    ViewData["Title"] = "DealerDetails";

#line default
#line hidden
            BeginContext(89, 60, true);
            WriteLiteral("\r\n<h2> Dealer Details</h2>\r\n\r\n<div>\r\n   \r\n    <hr />\r\n    \r\n");
            EndContext();
            BeginContext(1843, 109, true);
            WriteLiteral("            \r\n      \r\n\r\n\r\n\r\n\r\n       \r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1953, 46, false);
#line 60 "E:\Mono\MonoOvens\Views\Dealer\DealerDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.DealerName));

#line default
#line hidden
            EndContext();
            BeginContext(1999, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2055, 42, false);
#line 63 "E:\Mono\MonoOvens\Views\Dealer\DealerDetails.cshtml"
           Write(Html.DisplayFor(model => model.DealerName));

#line default
#line hidden
            EndContext();
            BeginContext(2097, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2153, 47, false);
#line 66 "E:\Mono\MonoOvens\Views\Dealer\DealerDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.DealerPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2200, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2256, 43, false);
#line 69 "E:\Mono\MonoOvens\Views\Dealer\DealerDetails.cshtml"
           Write(Html.DisplayFor(model => model.DealerPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2299, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2355, 48, false);
#line 72 "E:\Mono\MonoOvens\Views\Dealer\DealerDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.DealerRegion));

#line default
#line hidden
            EndContext();
            BeginContext(2403, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2459, 44, false);
#line 75 "E:\Mono\MonoOvens\Views\Dealer\DealerDetails.cshtml"
           Write(Html.DisplayFor(model => model.DealerRegion));

#line default
#line hidden
            EndContext();
            BeginContext(2503, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
            BeginContext(3816, 34, true);
            WriteLiteral("        </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3850, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70fd0711346648cdbab27ad3a7d63158", async() => {
                BeginContext(3902, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 123 "E:\Mono\MonoOvens\Views\Dealer\DealerDetails.cshtml"
                                 WriteLiteral(Model.Id);

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
            BeginContext(3910, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3918, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fecf1c9a98eb4ddf9deefadb114f9d51", async() => {
                BeginContext(3946, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3962, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<MonoOvens.Models.UserMaster> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MonoOvens.Models.DealerMaster> Html { get; private set; }
    }
}
#pragma warning restore 1591
