#pragma checksum "D:\tejas\MonoOvenProject\MonoOvens\Views\Asset\AssetsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "635becc6c132be4ed330c8a07e6fc927a2847058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asset_AssetsList), @"mvc.1.0.view", @"/Views/Asset/AssetsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asset/AssetsList.cshtml", typeof(AspNetCore.Views_Asset_AssetsList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"635becc6c132be4ed330c8a07e6fc927a2847058", @"/Views/Asset/AssetsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583fb51fb58d48fb43f505eee7f8118d921845d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Asset_AssetsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MonoOvens.Models.AssetMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateAsset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\tejas\MonoOvenProject\MonoOvens\Views\Asset\AssetsList.cshtml"
  
    ViewData["Title"] = "AssetList";

#line default
#line hidden
            BeginContext(97, 30, true);
            WriteLiteral("\r\n<h2>Assets</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6740d697cdb4599ae58d9814447e3b0", async() => {
                BeginContext(155, 10, true);
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
            BeginContext(169, 689, true);
            WriteLiteral(@"
</p>
<table style=""width:100%!important"" class=""table  table-bordered"" id=""assetsTable"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                FG code
            </th>
            <th>
                Asset Category
            </th>
            <th>
                Asset Type
            </th>
            <th>
                Controller Type
            </th>
            <th>
                No. of Controllers
            </th>
            <th>
                No. of Tray
            </th>
            <th>
                Tray Size(inch/mm)
            </th>
            <th>
                ");
            EndContext();
            BeginContext(859, 42, false);
#line 40 "D:\tejas\MonoOvenProject\MonoOvens\Views\Asset\AssetsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Handed));

#line default
#line hidden
            EndContext();
            BeginContext(901, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(957, 42, false);
#line 43 "D:\tejas\MonoOvenProject\MonoOvens\Views\Asset\AssetsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Format));

#line default
#line hidden
            EndContext();
            BeginContext(999, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1055, 41, false);
#line 46 "D:\tejas\MonoOvenProject\MonoOvens\Views\Asset\AssetsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 741, true);
            WriteLiteral(@"
            </th>
            <th>
                No. of Elements
            </th>
            <th>
                kW/h Rating per Element
            </th>
            <th>
                Type of Light
            </th>
            <th>
                No. of Lights
            </th>
            <th>
                kW/h Rating per Light
            </th>
            <th>
                No. of Fans
            </th>
            <th>
                kW/h Rating per Fan
            </th>
            <th>
                kW/h Rating Damper
            </th>
            <th>
                kW/h Rating WaterSolenoid
            </th>
            <th></th>
        </tr>
    </thead>
   
</table>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1854, 5143, true);
                WriteLiteral(@"

    <script language=""javascript"" type=""text/javascript"">
        var assetsTable;

         function EditAssetbyAdmin(id) {
            
            window.location.href = ""/Asset/EditAsset/"" + id;
          }
         function confirmDelete(callback) {
            bootbox.confirm({
                message: ""<h3>Are you sure, You want to Delete this record...!!</h3>"",
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

                //var data = customersTable.rows({ selected");
                WriteLiteral(@": true }).data();
                $.ajax({
                    type: ""GET"",
                    url:  ""/Asset/Delete"",
                    data: { id: id },
                    success: function (data) {
                        
                        assetsTable.draw(true);
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
             
             assetsTable = $('#assetsTable').DataTable({
                select: {
                    style: 'single'
                },
                //""order"": [[3, ""desc""]],
                ""ordering"": true, searching: true,                                   // make ordering ");
                WriteLiteral(@"false to getting the last out put as first.
                responsive: true, ""bProcessing"": true,
                ""bServerSide"": true,                                                   // paging
                ""sAjaxSource"": '/Asset/AssetAjaxDataProvider',
                ""columnDefs"": [
                    {
                        ""targets"": [0],
                        ""visible"": false,
                        ""searchable"": false
                    },
                    {
                        ""render"": function (data, type, row) {
                            return '<a href=""/Asset/EditAsset/' + data.id +'""  >Edit</a> |  <a id=""'+data.id+'"" onclick=""deleteSelectedItem(' + data.id + ')"">delete</a>'
                            //return '<a class=""btn btn-primary btn-link"" id=""' + data.id + '"" data-toggle=""tooltrip"" title="""" data-original-title=""Edit Detail"" onclick=""EditAssetbyAdmin(`' + data.id + '`)"">Edit</a> | <a class=""btn btn-danger btn-link""   id = ""' + data.id + '"" data - toggle=""t");
                WriteLiteral(@"ooltip"" title = """" data - original - title=""View Detail"" onclick = ""deleteSelectedItem(' + data.id + ')"" > Delete</a > '
                        },
                        ""targets"": 20
                    }
                ],
                 ""columns"": [   
                    { ""data"": ""id"" },
                    { ""data"": ""fG_Code"" },                    
                    { ""data"": ""assetCategory"" },
                    { ""data"": ""assetType"" },
                    { ""data"": ""controllerType"" },
                    { ""data"": ""controllers"" },
                    { ""data"": ""trays"" },
                    { ""data"": ""traySize"" },
                    //{
                    //    ""data"": ""trayHeight_inch"",
                    //    ""render"": function (data, type, row) {
                    //        return row.trayHeight_inch + '&Chi;' + row.trayWidth_inch
                    //    }
                    //},
                    { ""data"": ""handed"" },
                    { ""data"": ""format"" },");
                WriteLiteral(@"
                    { ""data"": ""power"" },
                     { ""data"": ""elements"" },
                     { ""data"": ""kWh_Rating_Element"" },
                     { ""data"": ""lightType"" },
                     { ""data"": ""lights"" },
                     { ""data"": ""kWh_Rating_Light"" },
                     { ""data"": ""fans"" },
                     { ""data"": ""kWh_Rating_Fan"" },
                     { ""data"": ""kWh_Rating_Damper"" },
                     { ""data"": ""kWh_Rating_WaterSolenoid"" },

                    {
                        ""orderable"": false,
                        ""searchable"": false,
                        ""data"": null
                    }
                ]
            });
            $('#assetsTable tbody').on('click', 'tr', function () {
                setTimeout(function () {
                    var selectedCount = assetsTable.rows({ selected: true }).count();
                    // toggleActionButtons(selectedCount > 0);
                }, 100)
            });
     ");
                WriteLiteral("   });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MonoOvens.Models.AssetMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
