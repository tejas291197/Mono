#pragma checksum "E:\Mono\MonoOvens\Views\User\UsersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b13ebf9c214c7d53c87c0d83e21c10359f83317"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UsersList), @"mvc.1.0.view", @"/Views/User/UsersList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UsersList.cshtml", typeof(AspNetCore.Views_User_UsersList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b13ebf9c214c7d53c87c0d83e21c10359f83317", @"/Views/User/UsersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583fb51fb58d48fb43f505eee7f8118d921845d4", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UsersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MonoOvens.Models.UserMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Mono\MonoOvens\Views\User\UsersList.cshtml"
  
    ViewData["Title"] = "UsersList";

#line default
#line hidden
            BeginContext(96, 29, true);
            WriteLiteral("\r\n<h2>Users</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(125, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62ee6ad6f47d427c88703cecc74aa4d9", async() => {
                BeginContext(152, 10, true);
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
            BeginContext(166, 281, true);
            WriteLiteral(@"
</p>
<table style=""width:100%!important"" class=""table  table-bordered"" id=""usersTable"">
    <thead>
        <tr>
          
            <th>
                Id
            </th>
            <th>
                Name
            </th>
            <th>
                ");
            EndContext();
            BeginContext(448, 41, false);
#line 23 "E:\Mono\MonoOvens\Views\User\UsersList.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(489, 154, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                AccessRole\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(660, 4305, true);
                WriteLiteral(@"

    <script language=""javascript"" type=""text/javascript"">
        var usersTable;

        function EditUserbyAdmin(id) {
            
            window.location.href = ""/User/EditUser/"" + id;
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

                //var data = customersTable.rows({ selected: true }).data();");
                WriteLiteral(@"
                $.ajax({
                    type: ""GET"",
                    url: ""/User/Delete"",
                    data: { Id: Id },
                    success: function (data) {

                        usersTable.draw(true);
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

            usersTable = $('#usersTable').DataTable({
                select: {
                    style: 'single'
                },
                //""order"": [[3, ""desc""]],
                ""ordering"": true, searching: true,                                   // make ordering false to getting the last out put as first.
                responsive: true, ""bProcessi");
                WriteLiteral(@"ng"": true,
                ""bServerSide"": true,                                                   // paging
                ""sAjaxSource"": '/User/UserAjaxDataProvider',
                ""columnDefs"": [
                    {
                        ""targets"": [0],
                        ""visible"": false,
                        ""searchable"": false
                    },
                    {
                        ""render"": function (data, type, row) {
    return '<a class=""btn btn-primary btn-link""   id=""' + data.id + '"" data-toggle=""tooltip"" title="""" data-original-title=""Edit Detail"" onclick=""EditUserbyAdmin(`' + data.id + '`)"">edit</a> | <a class=""btn btn-danger btn-link""   id=""' + data.id + '"" data-toggle=""tooltip"" title="""" data-original-title=""View Detail"" onclick=""deleteSelectedItem(`' + data.id + '`)"">delete</a>'
   // return '<a href=""/User/EditUser/' + data.id + '""  >Edit</a> <a href=""/User/UserDetails/' + data.id + '"" >Details</a>  <a class=""btn btn-danger btn-link"" onclick=""deleteSelect");
                WriteLiteral(@"edItem(' + data.id + ')"">delete</a>'
  //  return '<a class=""btn btn-danger btn-link""   id=""' + data.id + '"" data-toggle=""tooltip"" title="""" data-original-title=""View Detail"" onclick=""deleteSelectedItem(' + data.id + ')""><span class=""glyphicon glyphicon-trash""></span></a>'
                        },
                        ""targets"": 4
                    }
                ],
                ""columns"": [
                   
                    { ""data"": ""id"" },
                    
                    {
                        ""data"": ""name""
                        
                    },
                    { ""data"": ""email"" },
                    { ""data"": ""role"" },
                    {
                        ""orderable"": false,
                        ""searchable"": false,
                        ""data"": null
                    }
                ]
            });
            $('#usersTable tbody').on('click', 'tr', function () {
                setTimeout(function () {
           ");
                WriteLiteral("         var selectedCount = usersTable.rows({ selected: true }).count();\r\n                    // toggleActionButtons(selectedCount > 0);\r\n                }, 100)\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MonoOvens.Models.UserMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
