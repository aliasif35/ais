#pragma checksum "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2723b0ccbc545deff94ac346b6df080855e7c68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setup_departments), @"mvc.1.0.view", @"/Views/Setup/departments.cshtml")]
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
#nullable restore
#line 1 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\_ViewImports.cshtml"
using AIS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\_ViewImports.cshtml"
using AIS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2723b0ccbc545deff94ac346b6df080855e7c68", @"/Views/Setup/departments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83575d9a718d128afbe97793893afb3e648698d", @"/Views/_ViewImports.cshtml")]
    public class Views_Setup_departments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "472", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("472"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "494", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("494"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
  
    ViewData["Title"] = "Departments";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        var g_deptId = 0;
        $('#sidebar_policy').hide();
        $(""#searchTableRecord"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#listOfDepartment tbody tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });

    function newDeptSetup() {
        g_deptId = 0;
        $('#setupDeptModal').modal('show');
        $('#deptCodeModalField').val('');
        $('#deptNameModalField').val('');
        $('#deptdivNameModalField').val(0);
        $('#deptdivNameModalField').val(0);
    }

    function setupDepartment(code, name, div_name, status, id, div_id,audited_id) {
        g_deptId = id;
        $('#deptCodeModalField').val(code);
        $('#deptNameModalField').val(name);
        //audited_id

        $('#deptdivNameModalField').val(div_id);
        $('#deptAuditByNameM");
            WriteLiteral(@"odalField').val(audited_id);
        if (status == ""Active"")
            $('#deptActiveModalField').click();
        else if (status == ""InActive"")
            $('#deptInactiveModalField').click();

        $('#setupDeptModal').modal('show');
    }

    function publishDepartmentChanges() {

        var code = $('#deptCodeModalField').val();
        var name = $('#deptNameModalField').val();
        var div_id = $('#deptdivNameModalField').val();
        var auditby_id = $('#deptAuditByNameModalField option:selected').val();
        var div_name = $('#deptdivNameModalField option:selected').text();
        var status;
        var badge;
        if ($('#deptActiveModalField').is(':checked')) {
            status = 'Active';
            badge = 'badge-success ';
        }
        else {
            status = 'InActive';
            badge = 'badge-danger ';
        }
        if (auditby_id == 0) {
            alert(""Select Audit By Department"");
            return;
        }
       $");
            WriteLiteral(@"('#setupDeptModal').modal('hide');
        $.ajax({
            url: ""/Setup/department_add"",
            type: ""POST"",
            data: {
                'id': g_deptId,
                'code': code,
                'name': name,
                'div_id': div_id,
                'AUDITED_BY_DEPID': auditby_id,
                'status': status
            },
            cache: false,
            success: function (data) {
                //console.log(data);
                window.location = window.location.pathname;
            },
            dataType: ""json"",
        });
    }
</script>

<div class=""col-md-12"" style=""margin-top:20px;"">
    <h3>List of Departments</h3>
    <div class=""row"">
        <div class=""col-md-9"">
            <input class=""form-control"" id=""searchTableRecord"" type=""text"" placeholder=""Search.."">
        </div>
        <div class=""col-md-3"">
            <button onclick=""newDeptSetup();"" class=""btn btn-danger w-100"">Add New Department</button>
        </div");
            WriteLiteral(@">
    </div>
    <br>
    <table id=""listOfDepartment"" class=""table align-middle mb-0 bg-white table-hover table-striped"">
        <thead class=""bg-light"">
            <tr>
                <th class=""col-md-1"">Code</th>
                <th class=""col-md-3"">Name</th>
                <th class=""col-md-2"">Division Name</th>
                <th class=""col-md-3"">Audit By</th>
                <th class=""col-md-2"">Status</th>
                <th class=""col-md-1"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 109 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
              
                if (ViewData["DepartmentList"] != null)
                {
                    foreach (var item in (dynamic)(ViewData["DepartmentList"]))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 3908, "\"", 3928, 2);
            WriteAttributeValue("", 3913, "dept_", 3913, 5, true);
#nullable restore
#line 115 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
WriteAttributeValue("", 3918, item.CODE, 3918, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td class=\"dept_code\">\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 117 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                                     Write(item.CODE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td class=\"dept_name\">\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 120 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                                     Write(item.NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                            <td class=\"dept_div\">\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 123 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                                     Write(item.DIV_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <!--<p class=\"text-muted mb-0\">IT department</p>-->\r\n                            </td>\r\n                            <td class=\"dept_div\">\r\n                                <p class=\"fw-normal mb-1\">");
#nullable restore
#line 127 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                                     Write(item.AUDITED_BY_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <!--<p class=\"text-muted mb-0\">IT department</p>-->\r\n                            </td>\r\n                            <td class=\"dept_status\">\r\n");
#nullable restore
#line 131 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                  
                                    if (item.STATUS == "Active")

                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-success rounded-pill d-inline\">");
#nullable restore
#line 134 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                                                                         Write(item.STATUS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 134 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                                                                                                 }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-danger rounded-pill d-inline\">");
#nullable restore
#line 136 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                                                                    Write(item.STATUS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 136 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                                                                                            }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td class=\"dept_action\">\r\n                                <button type=\"button\" class=\"btn btn-link text-danger btn-sm btn-rounded\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5411, "\"", 5547, 15);
            WriteAttributeValue("", 5421, "setupDepartment(\'", 5421, 17, true);
#nullable restore
#line 140 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
WriteAttributeValue("", 5438, item.CODE, 5438, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5448, "\',\'", 5448, 3, true);
#nullable restore
#line 140 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
WriteAttributeValue("", 5451, item.NAME, 5451, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5461, "\',\'", 5461, 3, true);
#nullable restore
#line 140 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
WriteAttributeValue("", 5464, item.DIV_NAME, 5464, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5478, "\',\'", 5478, 3, true);
#nullable restore
#line 140 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
WriteAttributeValue("", 5481, item.STATUS, 5481, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5493, "\',\'", 5493, 3, true);
#nullable restore
#line 140 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
WriteAttributeValue("", 5496, item.ID, 5496, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5504, "\',\'", 5504, 3, true);
#nullable restore
#line 140 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
WriteAttributeValue("", 5507, item.DIV_ID, 5507, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5519, "\',\'", 5519, 3, true);
#nullable restore
#line 140 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
WriteAttributeValue("", 5522, item.AUDITED_BY_DEPID, 5522, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5544, "\');", 5544, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Edit\r\n                                </button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 145 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div id=""setupDeptModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-danger text-white"">
                <h5 class=""modal-title"">Department Setup</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2723b0ccbc545deff94ac346b6df080855e7c6816424", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""deptCodeModalField"">Code</label>
                        <input type=""text"" class=""form-control"" id=""deptCodeModalField"" aria-describedby=""brcode"" placeholder=""Department Code"">

                    </div>
                    <div class=""form-group"">
                        <label for=""deptNameModalField"">Name</label>
                        <input type=""text"" class=""form-control"" id=""deptNameModalField"" placeholder=""Department Name"">
                    </div>
                    <div class=""form-group"">
                        <label for=""deptdivNameModalField"">Division</label>
                        <select id=""deptdivNameModalField"" class=""form-select form-control"">
");
#nullable restore
#line 174 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                              
                                if (ViewData["DivisionList"] != null)
                                {
                                    foreach (var item in (dynamic)(ViewData["DivisionList"]))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2723b0ccbc545deff94ac346b6df080855e7c6817985", async() => {
#nullable restore
#line 179 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                                                                          Write(item.NAME);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 179 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                           WriteLiteral(item.DIVISIONID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 179 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
AddHtmlAttributeValue("", 7491, item.DIVISIONID, 7491, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 180 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\Setup\departments.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""deptAuditByNameModalField"">Audit by Department</label>
                        <select id=""deptAuditByNameModalField"" class=""form-select form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2723b0ccbc545deff94ac346b6df080855e7c6820979", async() => {
                    WriteLiteral("--Select Audit By Department--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2723b0ccbc545deff94ac346b6df080855e7c6822046", async() => {
                    WriteLiteral("CORPORATE AUDIT DEPARTMENT");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2723b0ccbc545deff94ac346b6df080855e7c6823405", async() => {
                    WriteLiteral("INFO. SYS. AUDIT DEPT");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""branchAddressModalField"">Status</label>
                        <div class=""row col-md-12"">
                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""deptActiveModalField"" value=""option1"" />
                                <label class=""form-check-label"" for=""deptActiveModalField"">Active</label>
                            </div>

                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""deptInactiveModalField"" value=""option2"" />
                                <label class=""form-check-label"" for=""deptInactiveModalField"">Inactive</label>
                            </div>
                        </div>
             ");
                WriteLiteral("       </div>\r\n\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button onclick=""publishDepartmentChanges();"" type=""button"" class=""btn btn-danger"">Save changes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

");
        }
        #pragma warning restore 1998
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
