#pragma checksum "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "934a3f14cf04aaeb202d820e4fb54b23114a95f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControllerModules_ControllerDetails), @"mvc.1.0.view", @"/Views/ControllerModules/ControllerDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ControllerModules/ControllerDetails.cshtml", typeof(AspNetCore.Views_ControllerModules_ControllerDetails))]
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
#line 1 "D:\tejas\temp\Mono\MonoOvens\Views\_ViewImports.cshtml"
using MonoOvens;

#line default
#line hidden
#line 2 "D:\tejas\temp\Mono\MonoOvens\Views\_ViewImports.cshtml"
using MonoOvens.Models;

#line default
#line hidden
#line 3 "D:\tejas\temp\Mono\MonoOvens\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"934a3f14cf04aaeb202d820e4fb54b23114a95f1", @"/Views/ControllerModules/ControllerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583fb51fb58d48fb43f505eee7f8118d921845d4", @"/Views/_ViewImports.cshtml")]
    public class Views_ControllerModules_ControllerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MonoOvens.Models.ControllerModule>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditController", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ControllersList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
  
    ViewData["Title"] = "ControllerDetails";

#line default
#line hidden
            BeginContext(97, 117, true);
            WriteLiteral("\r\n<h2>Controller Details</h2>\r\n\r\n<div>\r\n   \r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(215, 51, false);
#line 15 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.FirmwareVersion));

#line default
#line hidden
            EndContext();
            BeginContext(266, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(310, 47, false);
#line 18 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayFor(model => model.FirmwareVersion));

#line default
#line hidden
            EndContext();
            BeginContext(357, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(401, 51, false);
#line 21 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.SoftwareVersion));

#line default
#line hidden
            EndContext();
            BeginContext(452, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(496, 47, false);
#line 24 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayFor(model => model.SoftwareVersion));

#line default
#line hidden
            EndContext();
            BeginContext(543, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(587, 49, false);
#line 27 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.RecipeVersion));

#line default
#line hidden
            EndContext();
            BeginContext(636, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(680, 45, false);
#line 30 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayFor(model => model.RecipeVersion));

#line default
#line hidden
            EndContext();
            BeginContext(725, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(769, 41, false);
#line 33 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Skins));

#line default
#line hidden
            EndContext();
            BeginContext(810, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(854, 37, false);
#line 36 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Skins));

#line default
#line hidden
            EndContext();
            BeginContext(891, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(935, 45, false);
#line 39 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Wallpaper));

#line default
#line hidden
            EndContext();
            BeginContext(980, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1024, 41, false);
#line 42 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Wallpaper));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1109, 49, false);
#line 45 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.SevenDayTimer));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1202, 45, false);
#line 48 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayFor(model => model.SevenDayTimer));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1291, 46, false);
#line 51 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.SleepDelay));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1381, 42, false);
#line 54 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayFor(model => model.SleepDelay));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1467, 50, false);
#line 57 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ControllerDate));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1561, 46, false);
#line 60 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayFor(model => model.ControllerDate));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1651, 42, false);
#line 63 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1737, 38, false);
#line 66 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1775, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1822, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6410c7f3fdd040788214ea8072094fc1", async() => {
                BeginContext(1878, 4, true);
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
#line 71 "D:\tejas\temp\Mono\MonoOvens\Views\ControllerModules\ControllerDetails.cshtml"
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
            BeginContext(1886, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1894, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "660351017c1c460da97a12ae57d8303e", async() => {
                BeginContext(1926, 12, true);
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
            BeginContext(1942, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MonoOvens.Models.ControllerModule> Html { get; private set; }
    }
}
#pragma warning restore 1591
