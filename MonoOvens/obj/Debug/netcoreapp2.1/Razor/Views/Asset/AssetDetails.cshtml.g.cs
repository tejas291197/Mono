#pragma checksum "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19e33e4037533d7fe25e65920a563738a329921c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asset_AssetDetails), @"mvc.1.0.view", @"/Views/Asset/AssetDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asset/AssetDetails.cshtml", typeof(AspNetCore.Views_Asset_AssetDetails))]
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
#line 1 "E:\tejas\temp\Mono\MonoOvens\Views\_ViewImports.cshtml"
using MonoOvens;

#line default
#line hidden
#line 2 "E:\tejas\temp\Mono\MonoOvens\Views\_ViewImports.cshtml"
using MonoOvens.Models;

#line default
#line hidden
#line 3 "E:\tejas\temp\Mono\MonoOvens\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19e33e4037533d7fe25e65920a563738a329921c", @"/Views/Asset/AssetDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583fb51fb58d48fb43f505eee7f8118d921845d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Asset_AssetDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MonoOvens.Models.AssetMaster>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAsset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssetsList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
  
    ViewData["Title"] = "AssetDetails";

#line default
#line hidden
            BeginContext(87, 164, true);
            WriteLiteral("\r\n<h2>Asset Details</h2>\r\n\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Asset Category\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(252, 45, false);
#line 17 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.AssetCategory));

#line default
#line hidden
            EndContext();
            BeginContext(297, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(341, 43, false);
#line 20 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.FG_Code));

#line default
#line hidden
            EndContext();
            BeginContext(384, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(428, 39, false);
#line 23 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.FG_Code));

#line default
#line hidden
            EndContext();
            BeginContext(467, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            AssetType\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(563, 41, false);
#line 29 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.AssetType));

#line default
#line hidden
            EndContext();
            BeginContext(604, 101, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Controller Type\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(706, 46, false);
#line 35 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.ControllerType));

#line default
#line hidden
            EndContext();
            BeginContext(752, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(796, 47, false);
#line 38 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Controllers));

#line default
#line hidden
            EndContext();
            BeginContext(843, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(887, 43, false);
#line 41 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.Controllers));

#line default
#line hidden
            EndContext();
            BeginContext(930, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(974, 41, false);
#line 44 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Trays));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1059, 37, false);
#line 47 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.Trays));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Tray size\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1192, 40, false);
#line 53 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.TraySize));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(1401, 18, true);
            WriteLiteral("    <dt>\r\n        ");
            EndContext();
            BeginContext(1420, 42, false);
#line 59 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Handed));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(1494, 38, false);
#line 62 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.Handed));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(1564, 42, false);
#line 65 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Format));

#line default
#line hidden
            EndContext();
            BeginContext(1606, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(1638, 38, false);
#line 68 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.Format));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(1708, 41, false);
#line 71 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1749, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(1781, 37, false);
#line 74 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1818, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(1850, 44, false);
#line 77 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Elements));

#line default
#line hidden
            EndContext();
            BeginContext(1894, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(1926, 40, false);
#line 80 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.Elements));

#line default
#line hidden
            EndContext();
            BeginContext(1966, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(1998, 54, false);
#line 83 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.kWh_Rating_Element));

#line default
#line hidden
            EndContext();
            BeginContext(2052, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(2084, 50, false);
#line 86 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.kWh_Rating_Element));

#line default
#line hidden
            EndContext();
            BeginContext(2134, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(2166, 45, false);
#line 89 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.LightType));

#line default
#line hidden
            EndContext();
            BeginContext(2211, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(2243, 41, false);
#line 92 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.LightType));

#line default
#line hidden
            EndContext();
            BeginContext(2284, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(2316, 42, false);
#line 95 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Lights));

#line default
#line hidden
            EndContext();
            BeginContext(2358, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(2390, 38, false);
#line 98 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.Lights));

#line default
#line hidden
            EndContext();
            BeginContext(2428, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(2460, 52, false);
#line 101 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.kWh_Rating_Light));

#line default
#line hidden
            EndContext();
            BeginContext(2512, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(2544, 48, false);
#line 104 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.kWh_Rating_Light));

#line default
#line hidden
            EndContext();
            BeginContext(2592, 39, true);
            WriteLiteral("\r\n    </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2632, 40, false);
#line 107 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Fans));

#line default
#line hidden
            EndContext();
            BeginContext(2672, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2716, 36, false);
#line 110 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.Fans));

#line default
#line hidden
            EndContext();
            BeginContext(2752, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2796, 50, false);
#line 113 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.kWh_Rating_Fan));

#line default
#line hidden
            EndContext();
            BeginContext(2846, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2890, 46, false);
#line 116 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.kWh_Rating_Fan));

#line default
#line hidden
            EndContext();
            BeginContext(2936, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2980, 53, false);
#line 119 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.kWh_Rating_Damper));

#line default
#line hidden
            EndContext();
            BeginContext(3033, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3077, 49, false);
#line 122 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.kWh_Rating_Damper));

#line default
#line hidden
            EndContext();
            BeginContext(3126, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3170, 60, false);
#line 125 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.kWh_Rating_WaterSolenoid));

#line default
#line hidden
            EndContext();
            BeginContext(3230, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3274, 56, false);
#line 128 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.kWh_Rating_WaterSolenoid));

#line default
#line hidden
            EndContext();
            BeginContext(3330, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3377, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e33e4037533d7fe25e65920a563738a329921c17509", async() => {
                BeginContext(3428, 4, true);
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
#line 133 "E:\tejas\temp\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
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
            BeginContext(3436, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3444, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e33e4037533d7fe25e65920a563738a329921c19818", async() => {
                BeginContext(3471, 12, true);
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
            BeginContext(3487, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MonoOvens.Models.AssetMaster> Html { get; private set; }
    }
}
#pragma warning restore 1591
