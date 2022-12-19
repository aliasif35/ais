#pragma checksum "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AuditeePortal\observation_assigned.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9d33cfc69bb1d8852005465dfc5f3383807699f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AuditeePortal_observation_assigned), @"mvc.1.0.view", @"/Views/AuditeePortal/observation_assigned.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d33cfc69bb1d8852005465dfc5f3383807699f", @"/Views/AuditeePortal/observation_assigned.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83575d9a718d128afbe97793893afb3e648698d", @"/Views/_ViewImports.cshtml")]
    public class Views_AuditeePortal_observation_assigned : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AuditeePortal\observation_assigned.cshtml"
  
    ViewData["Title"] = "Observation Assigned";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    var g_obsId = 0;
    var g_obsTextId = 0;
    var g_obsList = [];
    $(document).ready(function () {

        $('#viewMemo_reply').richText({
            imageUpload: false,
            fileUpload: false,
            videoEmbed: false,
            urls: false
        });
    });
    function reloadLocation() {
        location.reload();
    }
    function showMemo(obs_id, obs_text_id, status, violation, nature, process, subprocess,checklist_detail) {
        $.each(g_obsList, function (i, v) {
            if (v.obS_ID == obs_id) {
                obs_text_id = v.obS_TEXT_ID;
                status = v.status;
                violation = v.violation;
                nature = v.nature;
                process = v.process;
                subprocess = v.suB_PROCESS;
                checklist_detail = v.checklisT_DETAIL;

            }
        })

        g_obsId=obs_id;
        g_obsTextId = obs_text_id;
        $.ajax({
            url: ""/A");
            WriteLiteral(@"piCalls/get_observation_text"",
            type: ""POST"",
            data: {
                'OBS_ID': g_obsId
            },
            cache: false,
            success: function (data) {

                $('#viewMemoModel').modal('show');
                $('#viewMemo_memo').html(data[0]);
                if (nature == """" && violation == """") {
                    $('#viewMemo_nature').html(nature);
                    $('#viewMemo_violation').html(violation);

                    $('#viewMemo_process').addClass('d-none');
                    $('#viewMemo_subprocess').addClass('d-none');
                    $('#viewMemo_checklist_detail').addClass('d-none');
                } else {
                    $('#viewMemo_nature').addClass('d-none');
                    $('#viewMemo_violation').addClass('d-none');
                    

                    $('#viewMemo_process').html(process);
                    $('#viewMemo_subprocess').html(subprocess);
                    $('#viewMemo_ch");
            WriteLiteral(@"ecklist_detail').html(checklist_detail);
                }
                
             
                if (status == 2) {
                    $('#replyButton_memoReply').removeClass('d-none');
                    $('#viewMemo_responded').parent().addClass('d-none');
                    $('#replyrichTextWrapper').removeClass('d-none');
                    $('#viewMemo_responded').html('');
                }
                else {
                    $('#replyButton_memoReply').addClass('d-none');
                    $('#viewMemo_responded').parent().removeClass('d-none');
                    $('#replyrichTextWrapper').addClass('d-none');
                    $('#viewMemo_responded').html(data[1]);
                    }

            },
            dataType: ""json"",
        });
    }
    function replyMemo() {
        var replyTxt = ($('#viewMemo_reply').val()).length;
        if (replyTxt > 0) {
            $.ajax({
                url: ""/ApiCalls/reply_observation"",
                ");
            WriteLiteral(@"type: ""POST"",
                data: {
                    'AU_OBS_ID': g_obsId,
                    'OBS_TEXT_ID': g_obsTextId,
                    'REPLY': $('#viewMemo_reply').val()
                },
                cache: false,
                success: function (data) {
                    alert(""Reply sent successfuly"");
                    onAlertCallback(reloadLocation);

                },
                dataType: ""json"",
            });
        } else {
            alert(""Provide your comments to proceed"");
            return false;
        }

    }

    function getEntityObservation() {
        $('#manageObsPanel tbody').empty();
        if ($('#entitySelectField option:selected').val() != 0) {
            $.ajax({
                url: ""/ApiCalls/get_assigned_observation"",
                type: ""POST"",
                data: {
                    'ENG_ID': $('#entitySelectField option:selected').val()
                },
                cache: false,
                su");
            WriteLiteral(@"ccess: function (data) {
                    g_obsList = data;
                    var sr = 1;
                    $.each(data, function (i, v) {
                        var sdate = v.memO_DATE.split("" "")[0];
                        var edate = v.memO_REPLY_DATE.split("" "")[0];                           
                        $('#manageObsPanel tbody').append('<tr><td class=""text-center"">' + sr + '</td><td>' + v.entitY_NAME + '</td><td>' + sdate + '</td><td>' + edate + '</td><td>' +v.status+'</td><td class=""text-center""><a onclick=""showMemo( '+ v.obS_ID +');"" class=""text-hover font-weight-bold text-success"">View</a></td></tr>');
                        sr++;
                          });

                },
                dataType: ""json"",
            });

        }
    }
</script>
<div class=""row col-md-12"">

    <div class=""row col-md-12 mt-3"">
        <h3 style=""color: #45c545;"">Assigned Observations</h3>
    </div>
    <div class=""row col-md-12 mt-3"">
        <div class=""col-md-2""");
            WriteLiteral(@">
            <label><b>Entity:</b></label>
        </div>
        <div class=""col-md-10"">
            <input id=""entityNameField"" disabled=""disabled"" class=""form-control ml-1 d-none"" type=""text"" />
            <select id=""entitySelectField"" onchange=""getEntityObservation()"" class=""form-control form-select"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d33cfc69bb1d8852005465dfc5f3383807699f9941", async() => {
                WriteLiteral("--Select Audit Entity--");
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
            WriteLiteral("\r\n");
#nullable restore
#line 150 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AuditeePortal\observation_assigned.cshtml"
                  
                    if (ViewData["EntitiesList"] != null)
                    {
                        foreach (var item in (dynamic)(ViewData["EntitiesList"]))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d33cfc69bb1d8852005465dfc5f3383807699f11637", async() => {
#nullable restore
#line 155 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AuditeePortal\observation_assigned.cshtml"
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
#line 155 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AuditeePortal\observation_assigned.cshtml"
                               WriteLiteral(item.ENG_ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 155 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AuditeePortal\observation_assigned.cshtml"
AddHtmlAttributeValue("", 5865, item.ENG_ID, 5865, 12, false);

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
#line 156 "D:\Audit Inspection Sol\ais\AIS\AIS\Views\AuditeePortal\observation_assigned.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </select>
        </div>
    </div>
    <div class=""row col-md-12 mt-3"">
        <table id=""manageObsPanel"" class=""table table-hover table-bordered table-hover mt-3 table-striped"">
            <thead style=""background-color: rgb(181 229 117 / 93%) !important; "">
                <tr>
                    <th class=""col-md-1"">Sr. No</th>
                    <th class=""col-md-4"">Entity</th>
                    <th class=""col-md-2"">Meno Date</th>
                    <th class=""col-md-2"">Reply Till </th>
                    <th class=""col-md-2"">Status</th>
                    <th class=""col-md-1""></th>
                </tr>
            </thead>
            <tbody>
              
            </tbody>
        </table>
    </div>
</div>


<div id=""viewMemoModel"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-xl"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-danger text-white"">
                <h5 clas");
            WriteLiteral(@"s=""modal-title"">Observation</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d33cfc69bb1d8852005465dfc5f3383807699f15602", async() => {
                WriteLiteral(@"

                    <div class=""form-group"">
                        <label for=""viewMemo_memo"">Violation</label>
                        <div id=""viewMemo_violation"" disabled=""disabled"" style=""max-height: 100px; height: auto; overflow-y: auto;"" class=""form-control""></div>
                    </div>
                    <div class=""form-group"">
                        <label for=""viewMemo_memo"">Nature</label>
                        <div id=""viewMemo_nature"" disabled=""disabled"" style=""max-height: 100px; height: auto; overflow-y: auto;"" class=""form-control""></div>
                    </div>
                    <div class=""form-group"">
                        <label for=""viewMemo_memo"">Process</label>
                        <div id=""viewMemo_process"" disabled=""disabled"" style=""max-height: 100px; height: auto; overflow-y: auto;"" class=""form-control""></div>
                    </div>
                    <div class=""form-group"">
                        <label for=""viewMemo_memo"">Sub Process</label");
                WriteLiteral(@">
                        <div id=""viewMemo_subprocess"" disabled=""disabled"" style=""max-height: 100px; height: auto; overflow-y: auto;"" class=""form-control""></div>
                    </div>
                    <div class=""form-group"">
                        <label for=""viewMemo_memo"">Checklist Detail</label>
                        <div id=""viewMemo_checklist_detail"" disabled=""disabled"" style=""max-height: 100px; height: auto; overflow-y: auto;"" class=""form-control""></div>
                    </div>
                    
                    <div class=""form-group"">
                        <label for=""viewMemo_memo"">Memo</label>
                        <div id=""viewMemo_memo"" disabled=""disabled"" style=""height: auto; overflow-y: auto;"" class=""form-control""></div>
                    </div>
                    <div class=""form-group d-none"">
                        <label for=""viewMemo_responded"">Management Response</label>
                        <div id=""viewMemo_responded"" disabled=""disabled"" sty");
                WriteLiteral(@"le=""height: auto; overflow-y: auto;"" class=""form-control""></div>
                    </div>
                    <div id=""replyrichTextWrapper"" class=""form-group"">
                        <label for=""viewMemo_reply"">Reply</label>
                        <textarea id=""viewMemo_reply"" style=""max-height:150px; height:auto;"" class=""form-control""></textarea>
                    </div>
                ");
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
                <button id=""replyButton_memoReply"" onclick=""replyMemo();"" type=""button"" data-dismiss=""modal"" class=""btn btn-danger"">Reply</button>
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
