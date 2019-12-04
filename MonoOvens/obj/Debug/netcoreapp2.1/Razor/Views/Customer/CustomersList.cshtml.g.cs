#pragma checksum "D:\tejas\MonoOvenProject\MonoOvens\Views\Customer\CustomersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b69b71c90167b1f3d91b36d746ce5184ba44509"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomersList), @"mvc.1.0.view", @"/Views/Customer/CustomersList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/CustomersList.cshtml", typeof(AspNetCore.Views_Customer_CustomersList))]
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
#line 1 "D:\tejas\MonoOvenProject\MonoOvens\Views\_ViewImports.cshtml"
using MonoOvens;

#line default
#line hidden
#line 2 "D:\tejas\MonoOvenProject\MonoOvens\Views\_ViewImports.cshtml"
using MonoOvens.Models;

#line default
#line hidden
#line 3 "D:\tejas\MonoOvenProject\MonoOvens\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b69b71c90167b1f3d91b36d746ce5184ba44509", @"/Views/Customer/CustomersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583fb51fb58d48fb43f505eee7f8118d921845d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CustomersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MonoOvens.Models.CustomerMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\tejas\MonoOvenProject\MonoOvens\Views\Customer\CustomersList.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 35, true);
            WriteLiteral("    <h2>Customers</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c1c5c19594445d482a2e865d44ff74c", async() => {
                BeginContext(162, 10, true);
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
            BeginContext(176, 493, true);
            WriteLiteral(@"
</p>
<table style=""width:100%!important"" class=""table table-bordered"" id=""customersTable"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Customer Name
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
            BeginContext(738, 143, true);
            WriteLiteral("                Head-Office\r\n            </th>\r\n\r\n            <th>\r\n                Zone\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(882, 42, false);
#line 38 "D:\tejas\MonoOvenProject\MonoOvens\Views\Customer\CustomersList.cshtml"
           Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
            EndContext();
            BeginContext(924, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(980, 40, false);
#line 41 "D:\tejas\MonoOvenProject\MonoOvens\Views\Customer\CustomersList.cshtml"
           Write(Html.DisplayNameFor(model => model.Area));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1076, 45, false);
#line 44 "D:\tejas\MonoOvenProject\MonoOvens\Views\Customer\CustomersList.cshtml"
           Write(Html.DisplayNameFor(model => model.StoreCode));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1177, 40, false);
#line 47 "D:\tejas\MonoOvenProject\MonoOvens\Views\Customer\CustomersList.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1273, 45, false);
#line 50 "D:\tejas\MonoOvenProject\MonoOvens\Views\Customer\CustomersList.cshtml"
           Write(Html.DisplayNameFor(model => model.StoreName));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 39, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
            EndContext();
            BeginContext(1434, 88, true);
            WriteLiteral("  Store-Address\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
            BeginContext(2293, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2322, 5362, true);
                WriteLiteral(@" 
    <script language=""javascript"" type=""text/javascript"">
        var customersTable;
         function EditCustomerbyAdmin(id) {
            
            window.location.href = ""/Customer/EditCustomer/"" + id;
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
          //  alert(""enteredinto delete"");
            confirmDelete(function () {

                //var d");
                WriteLiteral(@"ata = customersTable.rows({ selected: true }).data();
                $.ajax({
                    type: ""GET"",
                    url: ""/Customer/Delete"",
                    data: { id: id },
                    success: function (data) {

                       // customersTable.draw(true);
                         customersTable.draw(true);
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

            customersTable = $('#customersTable').DataTable({
                select: {
                    style: 'single'
                },
                //""order"": [[3, ""desc""]],
                ""ordering"": true, searching: true,                ");
                WriteLiteral(@"                   // make ordering false to getting the last out put as first.
                responsive: true, ""bProcessing"": true,
                ""bServerSide"": true,                                                   // paging
                ""sAjaxSource"": '/Customer/CustomerAjaxDataProvider',
                ""columnDefs"": [
                    {
                        ""targets"": [0],
                        ""visible"": false,
                        ""searchable"": false
                    },
                    {
                        ""render"": function (data, type, row) {
    return '<a class=""btn btn-primary btn-link""   id=""' + data.id + '"" data-toggle=""tooltip"" title="""" data-original-title=""Edit Detail"" onclick=""EditCustomerbyAdmin(`' + data.id + '`)"">edit</a> | <a class=""btn btn-danger btn-link""   id=""' + data.id + '"" data-toggle=""tooltip"" title="""" data-original-title=""View Detail"" onclick=""deleteSelectedItem(' + data.id + ')"">delete</a>'
   // return '<a href=""/User/EditUser/' + dat");
                WriteLiteral(@"a.id + '""  >Edit</a> <a href=""/User/UserDetails/' + data.id + '"" >Details</a>  <a class=""btn btn-danger btn-link"" onclick=""deleteSelectedItem(' + data.id + ')"">delete</a>'
  //  return '<a class=""btn btn-danger btn-link""   id=""' + data.id + '"" data-toggle=""tooltip"" title="""" data-original-title=""View Detail"" onclick=""deleteSelectedItem(' + data.id + ')""><span class=""glyphicon glyphicon-trash""></span></a>'
                        },
                        ""targets"": 13
                    }
                ],
                ""columns"": [
                     {""data"" :""id"" },
                    { ""data"": ""customerName"" },
                    { ""data"": ""primaryEmail"" },
                    { ""data"": ""primaryContactName"" },
                    { ""data"": ""primaryContactNumber"" },
                  
                    {
                        ""data"": ""hOAddress1"",
                        ""render"": function (data, type, row) {
                    return row.hoAddress1 + '&nbsp;' + row.hoAddress2  ");
                WriteLiteral(@"+ '&nbsp;' + row.hoAddress3  + '&nbsp;' + row.city   +'&nbsp;' + row.postcode
                        }
                    },
                    { ""data"": ""zone"" },
                    { ""data"": ""region"" },
                    { ""data"": ""area"" },
                    { ""data"": ""storeCode"" },
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
            $('#customersTable tbody').on('click', 'tr', function () {
                setTimeout(f");
                WriteLiteral("unction () {\r\n                    var selectedCount = customersTable.rows({ selected: true }).count();\r\n                    // toggleActionButtons(selectedCount > 0);\r\n                }, 100)\r\n            });\r\n        });\r\n\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MonoOvens.Models.CustomerMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
