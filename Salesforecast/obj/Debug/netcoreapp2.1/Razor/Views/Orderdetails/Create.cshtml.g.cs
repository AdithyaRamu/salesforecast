#pragma checksum "C:\Users\1025034\source\repos\sample-project\Salesforecast\Views\Orderdetails\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66f3ac9c8b4a86c96d560e2adf52052dcf82add8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orderdetails_Create), @"mvc.1.0.view", @"/Views/Orderdetails/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orderdetails/Create.cshtml", typeof(AspNetCore.Views_Orderdetails_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66f3ac9c8b4a86c96d560e2adf52052dcf82add8", @"/Views/Orderdetails/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f17a9da1907e887822f0d7d70b73da3ef454173", @"/Views/_ViewImports.cshtml")]
    public class Views_Orderdetails_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Salesforecast.Models.Orderdetails>
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\1025034\source\repos\sample-project\Salesforecast\Views\Orderdetails\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(86, 108, true);
            WriteLiteral("\r\n\r\n<h4>State Wise Percentage Forecast</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(194, 1917, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37ce85080fc2433eb8b3ab63ad35be51", async() => {
                BeginContext(220, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(234, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84f9c5b3532c4e66bf90c59af3e534ad", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 13 "C:\Users\1025034\source\repos\sample-project\Salesforecast\Views\Orderdetails\Create.cshtml"
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
                BeginContext(300, 1804, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <label class=""control-label"">Year of the Order</label>
                <select class=""form-control"" id=""orderyear""></select>

            </div>
            <div class=""form-group"">
                <label class=""control-label"">Percentage</label>
                <input class=""form-control"" type=""number"" step="".01"" id=""percentageinput"" />

            </div>
            <div class=""form-group"">
                <label class=""control-label"">Total Percentage of Sales</label>
                <div id=""totalpercent""></div>

            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <button id=""percentagesales"" onclick=""event.preventDefault()"" class=""btn btn-success"">SalesPercentage</button>
                    </div>
                    <div class=""col-md-4"">
                        <button id=""export"" style=""display:none"" onclick=""event.preventD");
                WriteLiteral(@"efault()"" class=""btn btn-success"">ExportData</button>
                    </div>
                    <div class=""col-md-4"">
                        <button id=""chart"" style=""display:none"" onclick=""event.preventDefault()"" class=""btn btn-success"">Viewchart</button>
                    </div>
                </div>
            </div>
            <div class=""form-group"" id=""chartdisplay"" style=""display:none"">
               
                    <div id=""container"" style=""width: 750px; height: 500px; margin: 0 auto""></div>
               
            </div>
                <div class=""form-group"">
                    
                            <table id=""percenttable"" class=""display nowrap table table-bordered""></table>

                </div>


        ");
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
            BeginContext(2111, 28, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2157, 9829, true);
                WriteLiteral(@"
    <script>
        let baseURL = ""../api/OrdersApi/"";
        var myTable;

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

                });
                $(""#orderyear"").html(options);
            }
        });

        /*  $(""#orderyear"").on('change', function () {

          });*/

        $('#percentagesales').on('click', function (event) {
            var orderyear ");
                WriteLiteral(@"= document.getElementById('orderyear').value;
            var percentageinput = document.getElementById('percentageinput').value;
            $.ajax({
                type: ""GET"",
                url: baseURL + 'gettotalprecentsales/' + orderyear + '/' + percentageinput,
                cache: false,
                contentType: ""application/json"",
                dataType: ""json"",

                success: function (response) {
                    tpercentage = '';
                    console.log(response);

                    tpercentage += '<p>Actual Sales : ' + response[0] + '</p>';
                    tpercentage += '<p>Forecasted Sales : ' + response[1] + '</p>';


                    $(""#totalpercent"").html(tpercentage);
                }
            });

            $(""#percenttable"").html('');

            $.ajax({
                type: ""GET"",
                url: baseURL + 'getpercentagesales/' + orderyear + '/' + percentageinput,
                cache: false,
           ");
                WriteLiteral(@"     contentType: ""application/json"",
                dataType: ""json"",
                /* beforeSend: function () {
                     $(""#EnvironmentLoader"").show();
                 },
                 complete: function () {
                     $(""#EnvironmentLoader"").hide();
                 },*/

                success: function (response) {
                    let currentTAbleValue = $(""#percenttable"").html();
                    console.log(currentTAbleValue);
                    if (currentTAbleValue == '') {
                        console.log('its null');


                    }
                    else {
                        $('#percenttable').DataTable().destroy();
                        $('#percenttable').empty();

                    }
                    console.log(response);
                    percentage = '';
                    percentage += '<thead style=""text-align:center;""></br><th>State</th></br></br><th>ActualSale</th></br></br></br></br><th style=""dis");
                WriteLiteral(@"play:none"">IncrementPercentage</th></br></br><th>ForecastedSale</th></br></br></thead>'

                    var i = 0;

                    nrOfRows = response.length;
                    for (i = 0; i < nrOfRows; i++) {

                        percentage += '<tr style=""text-align:center"" class=""col-md-10"">';



                        percentage += '<td class=""defaultflag"">' + response[i]['state'] + '</td>';
                        percentage += '<td class=""defaultflag"" >' + response[i]['actualSale'] + '</td>';
                        percentage += '<td class=""defaultflag"" style=""display:none"">' + percentageinput + '%</td>';
                        percentage += '<td class=""defaultflag"" >' + response[i]['predictedSale'] + '</td>';

                        percentage += '</tr>';

                    }

                    $(""#percenttable"").html('');
                    $(""#percenttable"").html(percentage);
                    $(""#export"").show();
                     $(""#chart"").show(");
                WriteLiteral(@");
                    
                    /*  myTable = $('#percenttable').DataTable({
                          lengthChange: false,
                          columnDefs: [{
                              orderable: false,
                              className: 'select-checkbox',
                              targets: 0
                          }],
                          select: {
                              style: 'single',
                              selector: 'td:first-child'
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
           ");
                WriteLiteral(@" });
        });
        $('#chart').on('click', function (event) {
              $(""#chartdisplay"").show();

            var states = [];
            var accept = [];
            var pred = [];
            $('#percenttable tr').each(function () {
                var state = $(this).find('td:eq(0)').text();
                var ac = parseFloat($(this).find('td:eq(1)').text());
                var pr = parseFloat($(this).find('td:eq(3)').text());
                states.push(state)
                accept.push(ac)
                pred.push(pr)
            });
            states.shift();
            var chartData = {
            chart: {
                type: 'column'
            },
            title: {
                text: 'State wise Sales'
            },
            xAxis: {
                categories:states
            },
            yAxis: {
                title: {
                    text: 'Sales ($)'
                }
            },
            series: [{
                n");
                WriteLiteral(@"ame: 'Actual Sales',
                data: accept
            },
            {
                name: 'Forcasted Sales',
                data: pred
            }]
        };

        // Create the chart
        var chart = Highcharts.chart('container', chartData);








        /*    var states = [];
            var accept = [];
            var pred = [];
            $('#percenttable tr').each(function () {
                var state = $(this).find('td:eq(0)').text();
                var ac = parseFloat($(this).find('td:eq(1)').text());
                var pr = parseFloat($(this).find('td:eq(3)').text());
                states.push(state)
                accept.push(ac)
                pred.push(pr)
            });
         //   var data = {
           //    table: 'percenttable'
           // };
          /*  var data = [{
                states: states,
                values: accept
            },
               {
                    states: states,
                 ");
                WriteLiteral(@"   values: pred
                }
            ]
           var data = {
              x : ['a', 'b'],
               values : [10,20] 
            }
            var chart = {
               type: 'column'
            };
            var title = {
               text: 'Data extracted from a HTML table in the page'   
            };    
         
            var yAxis = {
               allowDecimals: false,
               title: {
                  text: 'Units'
               }
            };
         /*   var series = [{
                name=""states""
                data=accept
            }]
         /*   var data1 = data.map( function(e) {
            return [e.gateway, parseFloat(e.val)];
});
            
           var tooltip = {
               formatter: function () {
                  return '<b>' + this.series.name + '</b><br/>' +
                     this.point.y + ' ' + this.point.name.toLowerCase();
               }
            };
            var credits = {
     ");
                WriteLiteral(@"          enabled: false
            };  
            var json = {};   
            json.chart = chart; 
            json.title = title; 
            json.data = data;
            console.log(data);
            json.yAxis = yAxis;
            json.credits = credits;  
            json.tooltip = tooltip;
            console.log(json)
            $('#container').highcharts(json); 

    */
        });






        const table = document.getElementById('percenttable');
const exportBtn = document.getElementById('export');

exportBtn.addEventListener('click', function () {
    // Export to csv
    const csv = toCsv(table);

    // Download it
    download(csv, 'ForecastedTable.csv');
});

        const toCsv = function (table) {
    // Query all rows
    const rows = table.querySelectorAll('tr');

    return [].slice
        .call(rows)
        .map(function (row) {
            // Query all cells
            const cells = row.querySelectorAll('th,td');
            return []");
                WriteLiteral(@".slice
                .call(cells)
                .map(function (cell) {
                    return cell.textContent;
                })
                .join(',');
        })
        .join('\n');
        };

        const download = function (text, fileName) {
    const link = document.createElement('a');
    link.setAttribute('href', `data:text/csv;charset=utf-8,${encodeURIComponent(text)}`);
    link.setAttribute('download', fileName);

    link.style.display = 'none';
    document.body.appendChild(link);

    link.click();

    document.body.removeChild(link);
};
    </script>
");
                EndContext();
            }
            );
            BeginContext(11989, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Salesforecast.Models.Orderdetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
