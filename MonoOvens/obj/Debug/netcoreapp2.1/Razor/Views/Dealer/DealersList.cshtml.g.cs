#pragma checksum "E:\tejas\temp\Mono\MonoOvens\Views\Dealer\DealersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbe8d4fb3611ab54235f7b806d1bf015edbe02cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dealer_DealersList), @"mvc.1.0.view", @"/Views/Dealer/DealersList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dealer/DealersList.cshtml", typeof(AspNetCore.Views_Dealer_DealersList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe8d4fb3611ab54235f7b806d1bf015edbe02cf", @"/Views/Dealer/DealersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583fb51fb58d48fb43f505eee7f8118d921845d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Dealer_DealersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MonoOvens.Models.DealerMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateDealer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\tejas\temp\Mono\MonoOvens\Views\Dealer\DealersList.cshtml"
  
    ViewData["Title"] = "DealersList";

#line default
#line hidden
            BeginContext(100, 31, true);
            WriteLiteral("\r\n<h2>Dealers</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbe8d4fb3611ab54235f7b806d1bf015edbe02cf3909", async() => {
                BeginContext(160, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(174, 715, true);
            WriteLiteral(@"
</p>
<table style=""width:100%!important"" class=""table  table-bordered"" id=""dealersTable"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Importer Name
            </th>
            <th>
                Dealer Name
            </th>
            <th>
                Dealer Region
            </th>
            <th>
                Dealer Phone
            </th>
          
            <th>
                Email
            </th>
            <th>
                Region
            </th>
            <th>
                Area
            </th>
          
            <th></th>
        </tr>
    </thead>

</table>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(906, 4285, true);
                WriteLiteral(@"

    <script language=""javascript"" type=""text/javascript"">
        var dealersTable;

        function EditDealerbyAdmin(id) {

            window.location.href = ""/Dealer/EditDealer/"" + id;
        }
        function confirmDelete(callback) {
            bootbox.confirm({
                message: ""<h3>Are you sure, You want to delete this record...!!</h3>"",
                buttons: {
                    confirm: {
                        label: 'Yes',
                        className: 'btn-success'
                    },
                    cancel: {
                        label: 'No',
                        className: 'btn-danger'
                    }
                },
                callback: function (result) {
                    if (result) callback();
                }
            });

        }

        function deleteSelectedItem(id) {

            confirmDelete(function () {

                //var data = customersTable.rows({ selected: true }).data();
       ");
                WriteLiteral(@"         $.ajax({
                    type: ""GET"",
                    url: ""/Dealer/Delete"",
                    data: { id: id },
                    success: function (data) {

                        dealersTable.draw(true);
                        // toggleActionButtons(false);
                        //  document.location.reload(true);
                    }

                }).fail(function (error) {
                    alert(error.statusText);
                    console.log(error);
                })
            });

        }

        $(document).ready(function () {
            //toggleActionButtons(false);

            dealersTable = $('#dealersTable').DataTable({
                select: {
                    style: 'single'
                },
                //""order"": [[3, ""desc""]],
                ""ordering"": true, searching: true,                                   // make ordering false to getting the last out put as first.
                responsive: true, ""bProcessi");
                WriteLiteral(@"ng"": true,
                ""bServerSide"": true,                                                   // paging
                ""sAjaxSource"": '/Dealer/DealerAjaxDataProvider',
                ""columnDefs"": [
                    {
                        ""targets"": [0],
                        ""visible"": false,
                        ""searchable"": false
                    },
                    {
                        ""render"": function (data, type, row) {
                            //return '<a href=""/Dealer/EditDealer/' + data.id +'""  >Edit</a> <a href=""/Dealer/DealerDetails/'+ data.id +'"" >Details</a>  <a id=""'+data.id+'"" onclick=""deleteSelectedItem(' + data.id + ')"">Delete</a>'
                            return '<a class=""btn btn-primary btn-link""   id=""' + data.id + '"" data-toggle=""tooltip"" title="""" data-original-title=""Edit Detail"" onclick=""EditDealerbyAdmin(`' + data.id + '`)"">Edit</a> | <a class=""btn btn-danger btn-link""   id=""' + data.id + '"" data-toggle=""tooltip"" title="""" data-original");
                WriteLiteral(@"-title=""View Detail"" onclick=""deleteSelectedItem(' + data.id + ')"">Delete</a>'
                        },                        
                         ""targets"": 8
                    }
                ],
                ""columns"": [
                    { ""data"": ""id"" },
               //     { ""data"": ""importerName"" },
                    { ""data"": ""impName"" },
                    { ""data"": ""dealerName"" },
                    { ""data"": ""dealerRegion"" },
                    { ""data"": ""dealerPhone"" },
                    { ""data"": ""email"" },
                    { ""data"": ""region"" },
                    { ""data"": ""area"" },                    
                    {
                        ""orderable"": false,
                        ""searchable"": false,
                        ""data"": null
                    }
                ]
            });
            $('#dealersTable tbody').on('click', 'tr', function () {
                setTimeout(function () {
                    var selectedC");
                WriteLiteral("ount = dealersTable.rows({ selected: true }).count();\r\n                    // toggleActionButtons(selectedCount > 0);\r\n                }, 100)\r\n            });\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MonoOvens.Models.DealerMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
