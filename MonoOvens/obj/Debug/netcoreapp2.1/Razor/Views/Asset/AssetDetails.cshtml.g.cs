#pragma checksum "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f193039874034759b52c29dc5fd552e60769cc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f193039874034759b52c29dc5fd552e60769cc", @"/Views/Asset/AssetDetails.cshtml")]
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
#line 3 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
  
    ViewData["Title"] = "AssetDetails";

#line default
#line hidden
            BeginContext(87, 107, true);
            WriteLiteral("\r\n<h2>Asset Details</h2>\r\n\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(195, 49, false);
#line 14 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.AssetCategory));

#line default
#line hidden
            EndContext();
            BeginContext(244, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(288, 45, false);
#line 17 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.AssetCategory));

#line default
#line hidden
            EndContext();
            BeginContext(333, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(377, 43, false);
#line 20 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.FG_Code));

#line default
#line hidden
            EndContext();
            BeginContext(420, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(464, 39, false);
#line 23 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.FG_Code));

#line default
#line hidden
            EndContext();
            BeginContext(503, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(547, 45, false);
#line 26 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.AssetType));

#line default
#line hidden
            EndContext();
            BeginContext(592, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(636, 41, false);
#line 29 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.AssetType));

#line default
#line hidden
            EndContext();
            BeginContext(677, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(721, 50, false);
#line 32 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.ControllerType));

#line default
#line hidden
            EndContext();
            BeginContext(771, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(815, 46, false);
#line 35 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.ControllerType));

#line default
#line hidden
            EndContext();
            BeginContext(861, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(905, 47, false);
#line 38 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Controllers));

#line default
#line hidden
            EndContext();
            BeginContext(952, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(996, 43, false);
#line 41 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.Controllers));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1083, 41, false);
#line 44 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Trays));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1168, 37, false);
#line 47 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.Trays));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Tray size\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1301, 40, false);
#line 53 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.TraySize));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(1510, 18, true);
            WriteLiteral("    <dt>\r\n        ");
            EndContext();
            BeginContext(1529, 42, false);
#line 59 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Handed));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(1603, 38, false);
#line 62 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.Handed));

#line default
#line hidden
            EndContext();
            BeginContext(1641, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(1673, 42, false);
#line 65 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Format));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(1747, 38, false);
#line 68 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.Format));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(1817, 41, false);
#line 71 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(1890, 37, false);
#line 74 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(1959, 44, false);
#line 77 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Elements));

#line default
#line hidden
            EndContext();
            BeginContext(2003, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(2035, 40, false);
#line 80 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.Elements));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(2107, 54, false);
#line 83 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.kWh_Rating_Element));

#line default
#line hidden
            EndContext();
            BeginContext(2161, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(2193, 50, false);
#line 86 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.kWh_Rating_Element));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(2275, 45, false);
#line 89 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.LightType));

#line default
#line hidden
            EndContext();
            BeginContext(2320, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(2352, 41, false);
#line 92 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.LightType));

#line default
#line hidden
            EndContext();
            BeginContext(2393, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(2425, 42, false);
#line 95 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Lights));

#line default
#line hidden
            EndContext();
            BeginContext(2467, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(2499, 38, false);
#line 98 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.Lights));

#line default
#line hidden
            EndContext();
            BeginContext(2537, 31, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(2569, 52, false);
#line 101 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayNameFor(Model => Model.kWh_Rating_Light));

#line default
#line hidden
            EndContext();
            BeginContext(2621, 31, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
            EndContext();
            BeginContext(2653, 48, false);
#line 104 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
   Write(Html.DisplayFor(Model => Model.kWh_Rating_Light));

#line default
#line hidden
            EndContext();
            BeginContext(2701, 39, true);
            WriteLiteral("\r\n    </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2741, 40, false);
#line 107 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Fans));

#line default
#line hidden
            EndContext();
            BeginContext(2781, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2825, 36, false);
#line 110 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.Fans));

#line default
#line hidden
            EndContext();
            BeginContext(2861, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2905, 50, false);
#line 113 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.kWh_Rating_Fan));

#line default
#line hidden
            EndContext();
            BeginContext(2955, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2999, 46, false);
#line 116 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.kWh_Rating_Fan));

#line default
#line hidden
            EndContext();
            BeginContext(3045, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3089, 53, false);
#line 119 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.kWh_Rating_Damper));

#line default
#line hidden
            EndContext();
            BeginContext(3142, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3186, 49, false);
#line 122 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.kWh_Rating_Damper));

#line default
#line hidden
            EndContext();
            BeginContext(3235, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3279, 60, false);
#line 125 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayNameFor(Model => Model.kWh_Rating_WaterSolenoid));

#line default
#line hidden
            EndContext();
            BeginContext(3339, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3383, 56, false);
#line 128 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
       Write(Html.DisplayFor(Model => Model.kWh_Rating_WaterSolenoid));

#line default
#line hidden
            EndContext();
            BeginContext(3439, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3486, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6e2544498b143e8842637c0bd8e8a62", async() => {
                BeginContext(3537, 4, true);
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
#line 133 "E:\Mono\MonoOvens\Views\Asset\AssetDetails.cshtml"
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
            BeginContext(3545, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3553, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "006a7aa3d9cf45f99f878d39c3d78895", async() => {
                BeginContext(3580, 12, true);
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
            BeginContext(3596, 10, true);
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
