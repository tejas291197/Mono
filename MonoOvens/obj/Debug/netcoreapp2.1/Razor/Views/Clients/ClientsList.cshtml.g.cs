#pragma checksum "D:\tejas\temp\Mono\MonoOvens\Views\Clients\ClientsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "633a998df66e32bc66f6ab57f837c2e651292565"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_ClientsList), @"mvc.1.0.view", @"/Views/Clients/ClientsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/ClientsList.cshtml", typeof(AspNetCore.Views_Clients_ClientsList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"633a998df66e32bc66f6ab57f837c2e651292565", @"/Views/Clients/ClientsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583fb51fb58d48fb43f505eee7f8118d921845d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_ClientsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MonoOvens.Models.ClientMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\tejas\temp\Mono\MonoOvens\Views\Clients\ClientsList.cshtml"
  
    ViewData["Title"] = "ClientsList";

#line default
#line hidden
            BeginContext(100, 31, true);
            WriteLiteral("\r\n<h2>Clients</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f1169a4410948d4b0d1ea7444b09c99", async() => {
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
            BeginContext(174, 565, true);
            WriteLiteral(@"
</p>
<table style=""width:100%!important"" class=""table  table-bordered"" id=""clientsTable"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Client Account No.
            </th>
            <th>
                Client Name
            </th>

            <th>
                Primary Contact Email
            </th>
            <th>
                Primary Contact Name
            </th>
            <th>
                Primary Contact Number
            </th>
            <th>
");
            EndContext();
            BeginContext(808, 146, true);
            WriteLiteral("                Head-Office\r\n            </th>\r\n\r\n            <th>\r\n                Country\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(955, 42, false);
#line 43 "D:\tejas\temp\Mono\MonoOvens\Views\Clients\ClientsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
            EndContext();
            BeginContext(997, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1053, 40, false);
#line 46 "D:\tejas\temp\Mono\MonoOvens\Views\Clients\ClientsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Area));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1149, 45, false);
#line 49 "D:\tejas\temp\Mono\MonoOvens\Views\Clients\ClientsList.cshtml"
           Write(Html.DisplayNameFor(model => model.StoreCode));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1250, 40, false);
#line 52 "D:\tejas\temp\Mono\MonoOvens\Views\Clients\ClientsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1346, 45, false);
#line 55 "D:\tejas\temp\Mono\MonoOvens\Views\Clients\ClientsList.cshtml"
           Write(Html.DisplayNameFor(model => model.StoreName));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 39, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
            EndContext();
            BeginContext(1507, 105, true);
            WriteLiteral("  Store-Address\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n   \r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1629, 5083, true);
                WriteLiteral(@"

    <script language=""javascript"" type=""text/javascript"">
        var clientsTable;

        function EditClientbyAdmin(id) {
            
            window.location.href = ""/Clients/EditClient/"" + id;
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

        function deleteSelectedItem(Id) {

            confirmDelete(function () {

                //var data = customersTable.rows({ selected: true");
                WriteLiteral(@" }).data();
                $.ajax({
                    type: ""GET"",
                    url:  ""/Clients/Delete"",
                    data: { Id: Id },
                    success: function (data) {

                        clientsTable.draw(true);
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

             clientsTable = $('#clientsTable').DataTable({
                select: {
                    style: 'single'
                },
                //""order"": [[3, ""desc""]],
                ""ordering"": true, searching: true,                                   // make ordering false to getting the last out put as first.
                respo");
                WriteLiteral(@"nsive: true, ""bProcessing"": true,
                ""bServerSide"": true,                                                   // paging
                ""sAjaxSource"": '/Clients/ClientAjaxDataProvider',
                 ""columnDefs"": [
                     {
                        ""targets"": [0],
                        ""visible"": false,
                        ""searchable"": false
                    },

                    {
                        ""render"": function (data, type, row) {
  //return '<a href=""/Clients/EditClient/' + data.id +'""  >Edit</a> <a href=""/Clients/ClientDetails/'+ data.id +'"" >Details</a>  <a id=""'+data.id+'"" onclick=""deleteSelectedItem(' + data.id + ')"">delete</a>'
    return '<a class=""btn btn-primary btn-link""   id=""' + data.id + '"" data-toggle=""tooltip"" title="""" data-original-title=""Edit Detail"" onclick=""EditClientbyAdmin(`' + data.id + '`)"">edit</a> | <a class=""btn btn-danger btn-link""   id=""' + data.id + '"" data-toggle=""tooltip"" title="""" data-original-title=""View Detail""");
                WriteLiteral(@" onclick=""deleteSelectedItem(' + data.id + ')"">delete</a>'
                        },
                        ""targets"": 14
                    }
                ],
                 ""columns"": [
                     { ""data"": ""id"" },
                     {""data"" : ""clientAccountNo""},
                    { ""data"": ""clientName"" },
                    { ""data"": ""primaryEmail"" },
                    { ""data"": ""primaryContactName"" },
                    { ""data"": ""primaryContactNumber"" },
                  
                    {
                        ""data"": ""hOAddress1"",
                        ""render"": function (data, type, row) {
                    return row.hoAddress1 + '&nbsp;' + row.hoAddress2  + '&nbsp;' + row.hoAddress3  + '&nbsp;' + row.city   +'&nbsp;' + row.postcode
                        }
                    },
                    { ""data"": ""country"" },
                    { ""data"": ""region"" },
                    { ""data"": ""area"" },
                    { ""data"": ""storeCode");
                WriteLiteral(@""" },
                    { ""data"": ""type"" },
                    { ""data"": ""storeName"" },   
                    {
                        ""data"": ""storeAddress1"",
                        ""render"": function (data, type, row) {
                    return row.storeAddress1 + '&nbsp;' + row.storeAddress2  + '&nbsp;' + row.postTown + '&nbsp;' +row.storePostcode
                        }
                    },                        
                    {
                        ""orderable"": false,
                        ""searchable"": false,
                        ""data"": null
                    }
                ]
            });
            $('#clientsTable tbody').on('click', 'tr', function () {
                setTimeout(function () {
                    var selectedCount = clientsTable.rows({ selected: true }).count();
                    // toggleActionButtons(selectedCount > 0);
                }, 100)
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MonoOvens.Models.ClientMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
