#pragma checksum "C:\Users\1025034\source\repos\sample-project\Salesforecast\Views\Orders\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11b4d42b21111601fe01d138d6ea762752d3ed33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Create), @"mvc.1.0.view", @"/Views/Orders/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Create.cshtml", typeof(AspNetCore.Views_Orders_Create))]
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
#line 1 "C:\Users\1025034\source\repos\sample-project\Salesforecast\Views\_ViewImports.cshtml"
using Salesforecast;

#line default
#line hidden
#line 2 "C:\Users\1025034\source\repos\sample-project\Salesforecast\Views\_ViewImports.cshtml"
using Salesforecast.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11b4d42b21111601fe01d138d6ea762752d3ed33", @"/Views/Orders/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f17a9da1907e887822f0d7d70b73da3ef454173", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Salesforecast.Models.Orders>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\1025034\source\repos\sample-project\Salesforecast\Views\Orders\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(80, 155, true);
            WriteLiteral("<style>\r\n    .DataTable_scroll {\r\n        overflow: auto;\r\n    }\r\n</style>\r\n<h4>SalesForcast </h4>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(235, 3358, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8d95fa740a1462f9a2235176b8667bc", async() => {
                BeginContext(261, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(275, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b39796652dc448f187bc94fedfe3d6d5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 15 "C:\Users\1025034\source\repos\sample-project\Salesforecast\Views\Orders\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(341, 3245, true);
                WriteLiteral(@"

            <div class=""form-group"">
                <label class=""control-label"">Year of the Order</label>
                <select class=""form-control"" id=""orderyear""></select>

            </div>
            <div class=""form-group"">
                <label class=""control-label"">Total Sales</label>
                <div id=""totalsales""></div>

            </div>
            <div class=""form-group"">
                <button id=""chart"" onclick=""event.preventDefault()"" class=""btn btn-default"">SateSales</button>
            </div>
            
                <div class=""form-group"">
                    <table id=""statetable"" class=""display nowrap table table-bordered""></table>
                </div>

                <!--


        <div class=""form-group"">
            <label asp-for=""ShipMode"" class=""control-label""></label>
            <input asp-for=""ShipMode"" class=""form-control"" />
            <span asp-validation-for=""ShipMode"" class=""text-danger""></span>
        </div>
        <di");
                WriteLiteral(@"v class=""form-group"">
            <label asp-for=""CustomerId"" class=""control-label""></label>
            <input asp-for=""CustomerId"" class=""form-control"" />
            <span asp-validation-for=""CustomerId"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <label asp-for=""CustomerName"" class=""control-label""></label>
            <input asp-for=""CustomerName"" class=""form-control"" />
            <span asp-validation-for=""CustomerName"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <label asp-for=""Segment"" class=""control-label""></label>
            <input asp-for=""Segment"" class=""form-control"" />
            <span asp-validation-for=""Segment"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <label asp-for=""Country"" class=""control-label""></label>
            <input asp-for=""Country"" class=""form-control"" />
            <span asp-validation-for=""Country"" class=""text-danger""></span>");
                WriteLiteral(@"
        </div>
        <div class=""form-group"">
            <label asp-for=""City"" class=""control-label""></label>
            <input asp-for=""City"" class=""form-control"" />
            <span asp-validation-for=""City"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <label asp-for=""State"" class=""control-label""></label>
            <input asp-for=""State"" class=""form-control"" />
            <span asp-validation-for=""State"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <label asp-for=""PostalCode"" class=""control-label""></label>
            <input asp-for=""PostalCode"" class=""form-control"" />
            <span asp-validation-for=""PostalCode"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <label asp-for=""Region"" class=""control-label""></label>
            <input asp-for=""Region"" class=""form-control"" />
            <span asp-validation-for=""Region"" class=""text-danger""></span>
    ");
                WriteLiteral("    </div>\r\n                <div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n                </div>-->\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3593, 90, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<!--<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>-->\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3701, 4822, true);
                WriteLiteral(@"
    <script>
        let baseURL = ""../api/OrdersApi/"";
        var myTableweb;
        var yearchart = new Array();

        
        $.ajax({
            type: ""GET"",
            url: baseURL + 'getorderyear',
            cache: false,
            contentType: ""application/json"",
            dataType: ""json"",
            /* beforeSend: function () {
                 $(""#EnvironmentLoader"").show();
             },
             complete: function () {
                 $(""#EnvironmentLoader"").hide();
             },*/

            success: function (response) {
                let data = [];
                let options = '';


                $.each(response, function (key, value) {
                    options += '<option value=""' + value['year'] + '"">' + value['year'] + '</option>';
                    yearchart.push(value['year']);
                });
                $(""#orderyear"").html(options);
                 $(""#orderyear"").trigger(""change"");
            }
        });
");
                WriteLiteral(@"
        $(""#orderyear"").on('change', function () {
            var orderyear = document.getElementById('orderyear').value;
            $.ajax({
                type: ""GET"",
                url: baseURL + 'gettotalsales/' + orderyear,
                cache: false,
                contentType: ""application/json"",
                dataType: ""json"",
                /* beforeSend: function () {
                     $(""#EnvironmentLoader"").show();
                 },
                 complete: function () {
                     $(""#EnvironmentLoader"").hide();
                 },*/

                success: function (response) {



                    $(""#totalsales"").html(response);
                }
            });

             $(""#statetable"").html('');
            var orderyear = document.getElementById('orderyear').value;
            $.ajax({
                type: ""GET"",
                url: baseURL + 'getstatesales/' + orderyear,
                cache: false,
                cont");
                WriteLiteral(@"entType: ""application/json"",
                dataType: ""json"",
                /* beforeSend: function () {
                     $(""#EnvironmentLoader"").show();
                 },
                 complete: function () {
                     $(""#EnvironmentLoader"").hide();
                 },*/

                success: function (response) {
                    let currentTAbleValue = $(""#statetable"").html();
                    console.log(currentTAbleValue);
                    if (currentTAbleValue == '') {
                        console.log('its null');


                    }
                    else {
                        //$('#statetable').DataTable().destroy();
                        $('#statetable').empty();

                    }
                    console.log(response);
                    state = '';
                    state += '<thead style=""text-align:center;""></br><th>State</th></br></br><th>TotalSales</th></br></br></thead>'

                    var i = 0;

");
                WriteLiteral(@"                    nrOfRows = response.length;
                    for (i = 0; i < nrOfRows; i++) {

                        state += '<tr style=""text-align:center"" class=""col-md-10"" href=""detail' + i + '"">';



                        state += '<td class=""defaultflag"">' + response[i]['state'] + '</td>';
                        state += '<td class=""defaultflag"" >' + response[i]['totalSales'] + '</td>';

                        state += '</tr>';

                    }

                    $(""#statetable"").html('');
                    $(""#statetable"").html(state);

               /*     myTableweb = $('#statetable').DataTable({
                          lengthChange: false,
                          columnDefs: [{
                              orderable: false,
                              className: 'select-checkbox',
                              targets: 0
                          }],
                          select: {
                              style: 'single',
            ");
                WriteLiteral(@"                  selector: 'td:first-child'
                          },
                          order: [[1, 'asc']],
                          ""oLanguage"": {
                              ""sSearch"": ""Search all columns:""
                          },
                          ""iDisplayLength"": 10,
                          ""bJQueryUI"": true,
                          ""sPaginationType"": ""full_numbers"",

                      });
                      $('.dataTable').wrap('<div class=""dataTables_scroll"" />');

                    */

                }
            });
        });

        /*  $('#statesales').on('click', function (event) {
            

        }); */


 

    </script>

");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Salesforecast.Models.Orders> Html { get; private set; }
    }
}
#pragma warning restore 1591
