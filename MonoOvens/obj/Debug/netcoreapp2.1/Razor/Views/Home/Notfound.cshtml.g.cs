#pragma checksum "D:\tejas\temp\Mono\MonoOvens\Views\Home\Notfound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a1d8bb56be94a7bcc0ce5a6cdb71be47ea18630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Notfound), @"mvc.1.0.view", @"/Views/Home/Notfound.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Notfound.cshtml", typeof(AspNetCore.Views_Home_Notfound))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a1d8bb56be94a7bcc0ce5a6cdb71be47ea18630", @"/Views/Home/Notfound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583fb51fb58d48fb43f505eee7f8118d921845d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Notfound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\tejas\temp\Mono\MonoOvens\Views\Home\Notfound.cshtml"
  
    ViewData["Title"] = "Notfound";

#line default
#line hidden
            BeginContext(44, 708, true);
            WriteLiteral(@"
<style>

</style>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""text-center error-pages"">
                <h1 class=""error-title text-danger""> 404</h1>
                <h2 class=""error-sub-title text-dark"">404 not found</h2>

                <p class=""error-message text-dark text-uppercase"">Sorry, An error has occured, Requested page not found!</p>

                <div class=""mt-4"">
                    <a href=""/"" class=""btn btn-primary btn-round shadow-primary m-1"">Go To Home </a>
                    <!--<a href=""javascript:void();"" class=""btn btn-outline-primary btn-round m-1"">Previous Page </a>-->
                </div>

");
            EndContext();
            BeginContext(948, 91, true);
            WriteLiteral("                <hr class=\"w-50\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
