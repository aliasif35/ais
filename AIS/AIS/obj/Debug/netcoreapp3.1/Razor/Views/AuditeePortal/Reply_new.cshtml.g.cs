#pragma checksum "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AuditeePortal\Reply_new.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847281caa8aade9ddca779da86e71f81917e212e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AuditeePortal_Reply_new), @"mvc.1.0.view", @"/Views/AuditeePortal/Reply_new.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847281caa8aade9ddca779da86e71f81917e212e", @"/Views/AuditeePortal/Reply_new.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83575d9a718d128afbe97793893afb3e648698d", @"/Views/_ViewImports.cshtml")]
    public class Views_AuditeePortal_Reply_new : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AuditeePortal\Reply_new.cshtml"
  
    ViewData["Title"] = "Reply";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    $('#document').ready(function () {
        $('#sidebar_policy').hide();
    });
</script>

<div class=""row"">
    <h4>Management Comments/Compliance of Audit Observation</h4>
</div>
<div class=""row col-md-12 mt-3"">
    <div class=""col-md-6 mt-3"">
        <label><b>Entity:</b></label>
        <input class=""form-control mr-1"" type=""text"" />
    </div>
    <div class=""col-md-6 mt-3"">
        <label><b>Audit Period:</b></label>
        <input class=""form-control ml-1"" type=""text"" />
    </div>
</div>
<div class=""row col-md-12 mt-3"">
    <label><b>Observation No:</b></label>
</div>
<div class=""row col-md-12"">
    <textarea class=""form-control form""></textarea>
</div>
<div class=""row col-md-12 mt-3"">
    <label><b>Reply:</b></label>
</div>
<div class=""row col-md-12"">
    <textarea class=""form-control form""></textarea>
</div>





<!--
<center class=""w-100"">
    <table class=""table table-bordered table-sm mb-0 mt-3 bg-white table-hover table-");
            WriteLiteral(@"striped"" style=""width:600px"" id=""Joining Report"">
        <thead>
            <tr>
                <td style=""text-align:left;"" colspan=""8""><h6>Audit Report:</h6></td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td width=""600"">Audit Date</td>
                <td width=""600""></td>
            </tr>
            <tr>
                <td width=""600"">Audit Zone</td>
                <td width=""600"">--</td>
            </tr>
            <tr>
                <td width=""600"">Branch</td>
                <td width=""600"">--</td>
            </tr>
            <tr>
                <td width=""600"">Division</td>
                <td width=""600"">--</td>
            </tr>
            <tr>
                <td width=""600"">Department</td>
                <td width=""600"">--</td>
            </tr>
            <tr>
                <td width=""600"">Audit Conducted by</td>
                <td width=""600"">--</td>
            </tr>
            <tr>
                <t");
            WriteLiteral(@"d width=""600"">Status</td>
                <td width=""600""></td>
            </tr>
        </tbody>
    </table>
</center>
</div>
<div class=""mt-3"">
    <table class=""table table-bordered mb-0 mt-3 bg-white table-hover table-striped"" id=""Reply"">
        <thead>
            <tr>
                <td class=""mh-50"" style=""text-align:left;"" colspan=""6""><h6>Audit Report</h6></td>
                <td style=""text-align:left;"" colspan=""6""><h6>Observation</h6></td>
                <td style=""text-align:left;"" colspan=""6""><h6>Audit Date</h6></td>
                <td style=""text-align:left;"" colspan=""6""><h6>Management Responce/Compliance</h6></td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td style=""text-align:left;"" colspan=""6""></td>
                <td style=""text-align:left;"" colspan=""6""></td>
                <td style=""text-align:left;"" colspan=""6""></td>
                <td style=""text-align:left;"" colspan=""6""></td>
            </tr>
            <tr>
 ");
            WriteLiteral(@"               <td style=""text-align:left;"" colspan=""6""></td>
                <td style=""text-align:left;"" colspan=""6""></td>
                <td style=""text-align:left;"" colspan=""6""></td>
                <td style=""text-align:left;"" colspan=""6""></td>
            </tr>
        </tbody>
    </table>
</div>-->
<div class=""row"">
    <div class=""col-md-6 mt-5"">
        <button class=""btn-primary"" style=""float:right;"">Save</button>
    </div>
    <div class=""col-md-6 mt-5"">
        <button class=""btn-primary"" style=""float:left;"">Submit</button>
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
