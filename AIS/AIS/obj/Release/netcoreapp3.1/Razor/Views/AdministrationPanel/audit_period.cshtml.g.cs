#pragma checksum "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\audit_period.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f4d756ce2cc4225f1b5e239c6bbf7172fe6b444"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministrationPanel_audit_period), @"mvc.1.0.view", @"/Views/AdministrationPanel/audit_period.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4d756ce2cc4225f1b5e239c6bbf7172fe6b444", @"/Views/AdministrationPanel/audit_period.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83575d9a718d128afbe97793893afb3e648698d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministrationPanel_audit_period : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AdministrationPanel\audit_period.cshtml"
  
    ViewData["Title"] = "BranchSetup";
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"">
    $(document).ready(function () {
        $('#sidebar_policy').hide();
        $(""#searchTableRecord"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#listOfBranches tbody tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });

    function newBranchSetup() {
        $('#setupBranchModal').modal('show');
        $('#branchCodeModalField').val('');
        $('#branchNameModalField').val('');
        $('#branchZoneModalField').val('');
        $('#branchAddressModalField').val('');
    }

    function setupBranch(code, name, zone, address, status) {
        $('#branchCodeModalField').val(code);
        $('#branchNameModalField').val(name);
        $('#branchZoneModalField').val(zone);
        $('#branchAddressModalField').val(address);
        if (status == ""Active"")
            $('#branchActiveModalField').click();
        else if (status == ""I");
            WriteLiteral("nactive\")\n            $(\'#branchInactiveModalField\').click();\n\n        $(\'#setupBranchModal\').modal(\'show\');\n    }\n\n    function publishBranchChanges() {\n        \n        //$(\'#listOfBranches tbody\').append(\'<tr><td></td>\');\n    }\n</script>\n\n\n");
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
