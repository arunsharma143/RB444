#pragma checksum "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\MarketWatch\TeamMarketWatch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "716f4bda4acb061cf3dedcc457e51a4cc7adc07a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MarketWatch_TeamMarketWatch), @"mvc.1.0.view", @"/Views/MarketWatch/TeamMarketWatch.cshtml")]
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
#line 1 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\_ViewImports.cshtml"
using RB444.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\_ViewImports.cshtml"
using RB444.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"716f4bda4acb061cf3dedcc457e51a4cc7adc07a", @"/Views/MarketWatch/TeamMarketWatch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1871d6f29a24f2b7248b00157ae42a3fab81e50", @"/Views/_ViewImports.cshtml")]
    public class Views_MarketWatch_TeamMarketWatch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/Img/chartIcon.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/chartIcon.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\MarketWatch\TeamMarketWatch.cshtml"
  
    ViewData["Title"] = "TeamMarketWatch";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .table-responsive {
        display: block;
        width: 100%;
        overflow-x: auto;
        -webkit-overflow-scrolling: touch;
        color: #3F4254;
        background-color: #E4E6EF;
    }

    .betfair-tbl {
        margin-bottom: 0;
    }

    .p-rltv {
        position: relative;
    }

    table {
        border-collapse: collapse;
        background-color: transparent;
    }

    .table > thead > tr > th, .table > tbody > tr > th, .table > tfoot > tr > th, .table > thead > tr > td, .table > tbody > tr > td, .table > tfoot > tr > td {
        padding: 8px;
        line-height: 1.42857143;
        vertical-align: top;
        border-top: 1px solid #ddd;
    }

    .tbl-bets th {
        padding: 5px;
        border-top: none;
        text-align: center;
    }

    .table td, .table th {
        padding: 0.75rem;
        vertical-align: top;
        border-top: 1px solid #c8ced3;
    }

    .show-xs {
        display: none;
    }

    .ba");
            WriteLiteral(@"ck-1 {
        background-color: #72bbef !important;
        border-left-color: #fff;
    }

    .lay-1 {
        background-color: #faa9ba !important;
        border-left-color: #fff;
    }

    .table tbody + tbody {
        border-top: 2px solid #c8ced3;
    }

    .tbl-bets .odd-row {
        border-bottom: 1px solid #ccc;
    }

    .odd-row .team-name {
        text-align: left;
        padding-left: 6px;
    }

    .tbl-bets td {
        text-align: center;
        font-size: 12x;
        padding: 3px 0;
        font-weight: 700;
        border-top: none;
    }

    .back-3 {
        background-color: #d7e8f4 !important;
        border-left-color: #fff;
    }

    .back-2 {
        background-color: #b7d5eb !important;
        border-left-color: #fff;
    }

    .lay-2 {
        background-color: #efd3d9 !important;
        border-left-color: #fff;
    }

    .lay-3 {
        background-color: #f6e6ea !important;
        border-left-color: #fff;
    }
");
            WriteLiteral(@"
    .tbl-bets .odd-row td span {
        display: block;
        font-weight: 400;
        font-size: 11px;
    }

    .minus-book {
        color: #d0021b;
        display: block;
        font-weight: 700 !important;
    }

    .odd-row .team-name .title {
        font-size: 12px;
        display: block;
        font-weight: 700;
    }

    .comCls {
        background-color: #878485 !important;
        border-left-color: #fff;
    }

    .commonCls {
        background-color: #6e6769 !important;
        border-left-color: #fff;
    }
</style>
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"">
<div class=""container"" style=""background-color: #363642; color: white; "">
    <div class=""row"">
        <div class=""col-sm-4 p-0"">
            <h3>South Africa v India</h3>
        </div>
        <div class=""col-sm-4"" style=""display: flex; justify-content: space-around;"">
            <h5>Bet Lock</h5>
            <h5>Fancy Lock</h5");
            WriteLiteral(@">
        </div>
        <div class=""col-sm-4"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-4 p-0"" style=""display: grid;"">
            <div class=""w-100"" style=""background-color: #6c6767; height: 10px; "">
            </div>

            <div class=""col-sm-12 p-0"">
                <div class=""w-100"" style=""display: flex; justify-content: space-between; background-color: #1e1e2d; margin-top: 10px; "">
                    <div");
            BeginWriteAttribute("class", " class=\"", 3644, "\"", 3652, 0);
            EndWriteAttribute();
            WriteLiteral(">match odd</div>\r\n                    <div style=\"display: flex;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "716f4bda4acb061cf3dedcc457e51a4cc7adc07a8385", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""form-check form-switch"">
                            <input class=""form-check-input"" type=""checkbox"" id=""mySwitch"" name=""darkmode"" value=""yes"" checked>
                        </div>
                    </div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table table-hover tbl-bets betfair-tbl p-rltv"">
                        <tr style=""background-color: #1e1e2d !important;color:white;"">
                            <th colspan=""1""></th>
                            <th colspan=""3"">Back</th>
                            <th colspan=""3"">Lay</th>
                        </tr>
                        <tbody>
                            <tr style=""position: relative;"" class=""odd-row"">

                                <td class=""team-name"">
                                    <span class=""title""> South Africa </span>

                                    <span class=""minus-book""><i class=""fa fa-arrow-right");
            WriteLiteral(@"""></i> 0.00 <span class=""BetvalueCls""></span></span>
                                </td>

                                <td class=""back-3 count 2954281""><a>5 <span>118.02</span></a></td>


                                <td class=""back-2 count 2954281""><a>5.1 <span>116.84</span></a></td>


                                <td class=""back-1 count 2954281""><a>5.2 <span>489.5</span></a></td>


                                <td class=""lay-1 count 2954281""><a>5.4 <span>114.23</span></a></td>


                                <td class=""lay-2 count 2954281""><a>8 <span>199.36</span></a></td>


                                <td class=""lay-3 count 2954281""><a>1,000 <span>52.56</span></a></td>

                            </tr>
                            <tr style=""position: relative;"" class=""odd-row"">

                                <td class=""team-name"">
                                    <span class=""title"">India </span>

                                    <span class=""minus-boo");
            WriteLiteral(@"k""><i class=""fa fa-arrow-right""></i> 0.00 <span class=""BetvalueCls1""></span></span>
                                </td>

                                <td class=""back-3 count 22121561""><a>3 <span>318.8</span></a></td>


                                <td class=""back-2 count 22121561""><a>4 <span>117.66</span></a></td>


                                <td class=""back-1 count 22121561""><a>4.1 <span>108.48</span></a></td>


                                <td class=""lay-1 count 22121561""><a>4.3 <span>1.2K</span></a></td>


                                <td class=""lay-2 count 22121561""><a>4.8 <span>119.91</span></a></td>


                                <td class=""lay-3 count 22121561""><a>6.8 <span>110.16</span></a></td>

                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""col-sm-12 p-0"">
                <div class=""w-100"" style=""display: flex; justify-content: space-betw");
            WriteLiteral("een; background-color: #1e1e2d; margin-top: 10px; \">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 6956, "\"", 6964, 0);
            EndWriteAttribute();
            WriteLiteral(">match odd</div>\r\n                    <div style=\"display: flex;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "716f4bda4acb061cf3dedcc457e51a4cc7adc07a13064", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""form-check form-switch"">
                            <input class=""form-check-input"" type=""checkbox"" id=""mySwitch"" name=""darkmode"" value=""yes"" checked>
                        </div>
                    </div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table table-hover tbl-bets betfair-tbl p-rltv"">
                        <tr style=""background-color: #1e1e2d !important;color:white;"">
                            <th colspan=""1""></th>
                            <th colspan=""3"">Back</th>
                            <th colspan=""3"">Lay</th>
                        </tr>
                        <tbody>
                            <tr style=""position: relative;"" class=""odd-row"">

                                <td class=""team-name"">
                                    <span class=""title""> South Africa </span>

                                    <span class=""minus-book""><i class=""fa fa-arrow-right");
            WriteLiteral(@"""></i> 0.00 <span class=""BetvalueCls""></span></span>
                                </td>

                                <td class=""back-3 count 2954281""><a>5 <span>118.02</span></a></td>


                                <td class=""back-2 count 2954281""><a>5.1 <span>116.84</span></a></td>


                                <td class=""back-1 count 2954281""><a>5.2 <span>489.5</span></a></td>


                                <td class=""lay-1 count 2954281""><a>5.4 <span>114.23</span></a></td>


                                <td class=""lay-2 count 2954281""><a>8 <span>199.36</span></a></td>


                                <td class=""lay-3 count 2954281""><a>1,000 <span>52.56</span></a></td>

                            </tr>
                            <tr style=""position: relative;"" class=""odd-row"">

                                <td class=""team-name"">
                                    <span class=""title"">India </span>

                                    <span class=""minus-boo");
            WriteLiteral(@"k""><i class=""fa fa-arrow-right""></i> 0.00 <span class=""BetvalueCls1""></span></span>
                                </td>

                                <td class=""back-3 count 22121561""><a>3 <span>318.8</span></a></td>


                                <td class=""back-2 count 22121561""><a>4 <span>117.66</span></a></td>


                                <td class=""back-1 count 22121561""><a>4.1 <span>108.48</span></a></td>


                                <td class=""lay-1 count 22121561""><a>4.3 <span>1.2K</span></a></td>


                                <td class=""lay-2 count 22121561""><a>4.8 <span>119.91</span></a></td>


                                <td class=""lay-3 count 22121561""><a>6.8 <span>110.16</span></a></td>

                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""col-sm-4"">
            <div class=""col-sm-12 p-0"" style=""border: solid #524f4f;"">
     ");
            WriteLiteral("           <div class=\"w-100\" style=\"display: flex; justify-content: space-between; background-color: #1e1e2d;\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 10328, "\"", 10336, 0);
            EndWriteAttribute();
            WriteLiteral(@">fall of First Wicket</div>
                    <div style=""display: flex;"">
                        <a>
                            <i class=""fa fa-eye fa-lg showModel""></i>
                        </a>
                    </div>
                </div>
                <div clss=""w-100"" style=""display: flex; justify-content: center;"">
                    <div class=""comCls w-100 text-center"">
                        <p style=""color: crimson; height: 35px; margin-bottom: 0px;"">Lay</p>
                        <p style=""height: 35px !important; margin-bottom: 0px;"">[No]</p>
                    </div>
                    <div class=""w-100 text-center"">
                        <p class=""lay-1"" style=""height: 35px !important; margin-bottom: 0px;"">22</p>
                        <p class=""commonCls"" style=""height: 35px !important; margin-bottom: 0px;"">95</p>
                    </div>
                    <div class=""comCls w-100 text-center"">
                        <p style=""color: blue; height: 35p");
            WriteLiteral(@"x; margin-bottom: 0px;"">Back</p>
                        <p style=""height: 35px !important; margin-bottom: 0px;"">[Yes]</p>
                    </div>
                    <div class=""w-100 text-center"">
                        <p class=""back-1"" style=""height: 35px !important; margin-bottom: 0px;"">22</p>
                        <p class=""commonCls"" style=""height: 35px !important; margin-bottom: 0px;"">95</p>
                    </div>
                </div>
                <div clss=""w-100"" style=""display: flex; justify-content: space-between;"">
                    <div class=""form-check m-3"">
                        <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault1"" checked>
                        <label class=""form-check-label"" for=""flexRadioDefault1"">
                            Active
                        </label>
                    </div>
                    <div class=""form-check m-3"">
                        <input class=""form-check-input"" type");
            WriteLiteral(@"=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault2"">
                        <label class=""form-check-label"" for=""flexRadioDefault2"">
                            Inactive
                        </label>
                    </div>
                    <div class=""form-check m-3"">
                        <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault3"">
                        <label class=""form-check-label"" for=""flexRadioDefault3"">
                            Suspend
                        </label>
                    </div>
                    <div>
                        <p style=""width: 25px; height: 25px; background: #03acbd; border-radius: 50%; font-size: 18px; color: #fff; text-align: center; margin: 12px 20px;"">R</p>
                    </div>

                </div>
            </div>
            <div class=""col-sm-12 p-0"" style=""border: solid #524f4f;"">
                <div class=""w-100"" style=""display: flex; justify-content: space-bet");
            WriteLiteral("ween; background-color: #1e1e2d;\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 13469, "\"", 13477, 0);
            EndWriteAttribute();
            WriteLiteral(@">fall of First Wicket</div>
                    <div style=""display: flex;"">
                        <a>
                            <i class=""fa fa-eye fa-lg showModel""></i>
                        </a>
                    </div>
                </div>
                <div clss=""w-100"" style=""display: flex; justify-content: center;"">
                    <div class=""comCls w-100 text-center"">
                        <p style=""color: crimson; height: 35px; margin-bottom: 0px;"">Lay</p>
                        <p style=""height: 35px !important; margin-bottom: 0px;"">[No]</p>
                    </div>
                    <div class=""w-100 text-center"">
                        <p class=""lay-1"" style=""height: 35px !important; margin-bottom: 0px;"">22</p>
                        <p class=""commonCls"" style=""height: 35px !important; margin-bottom: 0px;"">95</p>
                    </div>
                    <div class=""comCls w-100 text-center"">
                        <p style=""color: blue; height: 35p");
            WriteLiteral(@"x; margin-bottom: 0px;"">Back</p>
                        <p style=""height: 35px !important; margin-bottom: 0px;"">[Yes]</p>
                    </div>
                    <div class=""w-100 text-center"">
                        <p class=""back-1"" style=""height: 35px !important; margin-bottom: 0px;"">22</p>
                        <p class=""commonCls"" style=""height: 35px !important; margin-bottom: 0px;"">95</p>
                    </div>
                </div>
                <div clss=""w-100"" style=""display: flex; justify-content: space-between;"">
                    <div class=""form-check m-3"">
                        <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault1"" checked>
                        <label class=""form-check-label"" for=""flexRadioDefault1"">
                            Active
                        </label>
                    </div>
                    <div class=""form-check m-3"">
                        <input class=""form-check-input"" type");
            WriteLiteral(@"=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault2"">
                        <label class=""form-check-label"" for=""flexRadioDefault2"">
                            Inactive
                        </label>
                    </div>
                    <div class=""form-check m-3"">
                        <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault3"">
                        <label class=""form-check-label"" for=""flexRadioDefault3"">
                            Suspend
                        </label>
                    </div>
                    <div>
                        <p style=""width: 25px; height: 25px; background: #03acbd; border-radius: 50%; font-size: 18px; color: #fff; text-align: center; margin: 12px 20px;"">R</p>
                    </div>

                </div>
            </div>
            <div class=""col-sm-12 p-0"" style=""border: solid #524f4f;"">
                <div class=""w-100"" style=""display: flex; justify-content: space-bet");
            WriteLiteral("ween; background-color: #1e1e2d;\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 16610, "\"", 16618, 0);
            EndWriteAttribute();
            WriteLiteral(@">fall of First Wicket</div>
                    <div style=""display: flex;"">
                        <a>
                            <i class=""fa fa-eye fa-lg showModel""></i>
                        </a>
                    </div>
                </div>
                <div clss=""w-100"" style=""display: flex; justify-content: center;"">
                    <div class=""comCls w-100 text-center"">
                        <p style=""color: crimson; height: 35px; margin-bottom: 0px;"">Lay</p>
                        <p style=""height: 35px !important; margin-bottom: 0px;"">[No]</p>
                    </div>
                    <div class=""w-100 text-center"">
                        <p class=""lay-1"" style=""height: 35px !important; margin-bottom: 0px;"">22</p>
                        <p class=""commonCls"" style=""height: 35px !important; margin-bottom: 0px;"">95</p>
                    </div>
                    <div class=""comCls w-100 text-center"">
                        <p style=""color: blue; height: 35p");
            WriteLiteral(@"x; margin-bottom: 0px;"">Back</p>
                        <p style=""height: 35px !important; margin-bottom: 0px;"">[Yes]</p>
                    </div>
                    <div class=""w-100 text-center"">
                        <p class=""back-1"" style=""height: 35px !important; margin-bottom: 0px;"">22</p>
                        <p class=""commonCls"" style=""height: 35px !important; margin-bottom: 0px;"">95</p>
                    </div>
                </div>
                <div clss=""w-100"" style=""display: flex; justify-content: space-between;"">
                    <div class=""form-check m-3"">
                        <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault1"" checked>
                        <label class=""form-check-label"" for=""flexRadioDefault1"">
                            Active
                        </label>
                    </div>
                    <div class=""form-check m-3"">
                        <input class=""form-check-input"" type");
            WriteLiteral(@"=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault2"">
                        <label class=""form-check-label"" for=""flexRadioDefault2"">
                            Inactive
                        </label>
                    </div>
                    <div class=""form-check m-3"">
                        <input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault3"">
                        <label class=""form-check-label"" for=""flexRadioDefault3"">
                            Suspend
                        </label>
                    </div>
                    <div>
                        <p style=""width: 25px; height: 25px; background: #03acbd; border-radius: 50%; font-size: 18px; color: #fff; text-align: center; margin: 12px 20px;"">R</p>
                    </div>

                </div>
            </div>
        </div>
        <div class=""col-sm-4"">
            <div class=""col-sm-12 p-0"">
                <div class=""w-100"" style=""display: flex; justify-c");
            WriteLiteral(@"ontent: start; background-color: #1e1e2d;"">
                    <div>Live Tv</div>
                </div>
            </div>
            <div class=""col-sm-12 p-0 mt-4"">
                <div class=""w-100"" style=""display: flex; justify-content: start; background-color: #1e1e2d;"">
                    <div>Current User Postion</div>
                </div>
            </div>
            <div class=""col-sm-12 p-0 mt-4"">
                <div class=""w-100"" style=""display: flex; justify-content: start; background-color: #1e1e2d;"">
                    <div>Unmatched Bet(0)</div>
                </div>
            </div>
            <div class=""col-sm-12 p-0 mt-4"">
                <div class=""w-100"" style=""display: flex; justify-content: start; background-color: #1e1e2d;"">
                    <div>Matched Bet(2)</div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <tr style=""background-color: #1e1e2d !important;");
            WriteLiteral(@"color:white;"">
                            <th>S.No.</th>
                            <th colspan=""2""></th>
                            <th>User</th>
                            <th>Runner</th>
                            <th>Odds</th>
                            <th>Stack</th>
                            <th>P&L</th>
                        </tr>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>D</td>
                                <td>C</td>
                                <td>Demou</td>
                                <td>asfsdf sf s fsd fds f</td>
                                <td>53.00</td>
                                <td>400</td>
                                <td>400</td>
                            </tr>
                            <tr>
                                <td>1</td>
                                <td>D</td>
                                <td>C</td>
             ");
            WriteLiteral(@"                   <td>Demou</td>
                                <td>asfsdf sf s fsd fds f</td>
                                <td>53.00</td>
                                <td>400</td>
                                <td>400</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""col-sm-12 p-0 mt-4"">
                <div class=""w-100"" style=""display: flex; justify-content: start; background-color: #1e1e2d;"">
                    <div>Fancy Bet(2)</div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <tr style=""background-color: #1e1e2d !important;color:white;"">
                            <th>S.No.</th>
                            <th colspan=""2""></th>
                            <th>User</th>
                            <th>Runner</th>
                            <th>Odds</th>
           ");
            WriteLiteral(@"                 <th>Stack</th>
                            <th>P&L</th>
                        </tr>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>D</td>
                                <td>C</td>
                                <td>Demou</td>
                                <td>asfsdf sf s fsd fds f</td>
                                <td>53.00</td>
                                <td>400</td>
                                <td>400</td>
                            </tr>
                            <tr>
                                <td>1</td>
                                <td>D</td>
                                <td>C</td>
                                <td>Demou</td>
                                <td>asfsdf sf s fsd fds f</td>
                                <td>53.00</td>
                                <td>400</td>
                                <td>400</td>
              ");
            WriteLiteral("              </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
