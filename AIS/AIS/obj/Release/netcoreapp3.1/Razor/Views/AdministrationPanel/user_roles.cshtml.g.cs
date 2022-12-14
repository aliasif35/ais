#pragma checksum "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "766eb18eab0d4733453984fc287e3da096dca2e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministrationPanel_user_roles), @"mvc.1.0.view", @"/Views/AdministrationPanel/user_roles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"766eb18eab0d4733453984fc287e3da096dca2e0", @"/Views/AdministrationPanel/user_roles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83575d9a718d128afbe97793893afb3e648698d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministrationPanel_user_roles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
  
    ViewData["Title"] = "UserRoles";
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        $('.menu_page_selectAll').on('click', function () {

            if ($('.menu_page_selectAll').is(':checked'))
                $('.menu_page_tick').attr('checked', true);
            else
                $('.menu_page_tick').attr('checked', false);

        });
       
    });
</script>

<div class=""col-md-12"" style=""margin-top:20px;"">
    <h5>User Roles</h5>
    <div class=""row col-md-12"">
        <div class=""col-md-3 mt-3"">
            <label>User</label>
        </div>
        <div class=""col-md-9 mt-3"">
            <select id=""userSelectionBox"" class=""form-control select-picker"" data-live-search=""true"" aria-label=""Default select example"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "766eb18eab0d4733453984fc287e3da096dca2e04397", async() => {
                WriteLiteral("--Select User--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                  
                    if (ViewData["UserList"] != null)
                    {
                        foreach (var item in (dynamic)(ViewData["UserList"]))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "766eb18eab0d4733453984fc287e3da096dca2e06300", async() => {
#nullable restore
#line 35 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                                                                  Write(item.PPNO);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;--&nbsp; ");
#nullable restore
#line 35 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                                                                                            Write(item.EMPLOYEEFIRSTNAME);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp; &nbsp; ");
#nullable restore
#line 35 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                                                                                                                                  Write(item.EMPLOYEELASTNAME);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                               WriteLiteral(item.PPNO);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 35 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
AddHtmlAttributeValue("", 1155, item.PPNO, 1155, 10, false);

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
#line 36 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
    </div>
    <div class=""row col-md-12 d-none-1"">
        <div class=""col-md-3 mt-2"">
            <label>Group/Role</label>
        </div>
        <div class=""col-md-9 mt-2"">
            <select id=""groupSelectionBox"" class=""form-select form-control"" aria-label=""Default select example"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "766eb18eab0d4733453984fc287e3da096dca2e09912", async() => {
                WriteLiteral("--Select Group/Roles--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                  
                    if (ViewData["GroupList"] != null)
                    {
                        foreach (var item in (dynamic)(ViewData["GroupList"]))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "766eb18eab0d4733453984fc287e3da096dca2e011824", async() => {
#nullable restore
#line 54 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                                                                          Write(item.GROUP_NAME);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                               WriteLiteral(item.GROUP_ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 54 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
AddHtmlAttributeValue("", 2014, item.GROUP_ID, 2014, 14, false);

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
#line 55 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
    </div>
    <div class=""row col-md-12 d-none-1"">
        <div class=""col-md-3 mt-2"">
            <label>Menu</label>
        </div>
        <div class=""col-md-9 mt-2"">
            <select id=""menuSelectionBox"" class=""form-select form-control"" aria-label=""Default select example"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "766eb18eab0d4733453984fc287e3da096dca2e014744", async() => {
                WriteLiteral("--Select Menu--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 68 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                  
                    if (ViewData["MenuList"] != null)
                    {
                        foreach (var item in (dynamic)(ViewData["MenuList"]))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "766eb18eab0d4733453984fc287e3da096dca2e016648", async() => {
#nullable restore
#line 73 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                                                                        Write(item.Menu_Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                               WriteLiteral(item.Menu_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 73 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
AddHtmlAttributeValue("", 2790, item.Menu_Id, 2790, 13, false);

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
#line 74 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
    </div>
    <div class=""row col-md-12 d-none-1"">
        <div class=""col-md-3 mt-2"">
            <label>Pages</label>
        </div>
        <div class=""col-md-9 mt-2"">
            <div class=""row col-md-12"">
                <div style=""margin-left:auto;"">
                    <input class=""menu_page_selectAll"" type=""checkbox"" /> <label class=""font-weight-normal ml-2"">Select All</label>
                </div>
            </div>
            <div class=""row col-md-12"">
");
#nullable restore
#line 91 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                  
                    if (ViewData["MenuPagesList"] != null)
                    {

                        foreach (var item in (dynamic)(ViewData["MenuPagesList"]))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-6\">\r\n                                <input");
            BeginWriteAttribute("id", " id=\"", 3733, "\"", 3746, 1);
#nullable restore
#line 99 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
WriteAttributeValue("", 3738, item.Id, 3738, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu_page_tick\" type=\"checkbox\" /> <label class=\"font-weight-normal ml-2\">");
#nullable restore
#line 99 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                                                                                                                                 Write(item.Page_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n");
#nullable restore
#line 101 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\user_roles.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""row col-md-12 d-none-1"">
        <div style=""margin-left:auto;"">
            <button class=""btn btn-secondary"">Cancel</button>
            <button class=""btn btn-danger ml-2"">Save Changes</button>
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
