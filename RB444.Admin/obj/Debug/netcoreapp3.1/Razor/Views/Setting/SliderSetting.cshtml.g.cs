#pragma checksum "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\Setting\SliderSetting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec0ee762a79e46dc60042148bb8ccc089e75f0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setting_SliderSetting), @"mvc.1.0.view", @"/Views/Setting/SliderSetting.cshtml")]
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
#nullable restore
#line 1 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\Setting\SliderSetting.cshtml"
using RB444.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec0ee762a79e46dc60042148bb8ccc089e75f0c", @"/Views/Setting/SliderSetting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1871d6f29a24f2b7248b00157ae42a3fab81e50", @"/Views/_ViewImports.cshtml")]
    public class Views_Setting_SliderSetting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Slider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/SaveSliderImages"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\Setting\SliderSetting.cshtml"
  
    ViewData["Title"] = "Slider Setting";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>Slider Images</h2>\r\n    <div class=\"row p-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ec0ee762a79e46dc60042148bb8ccc089e75f0c4378", async() => {
                WriteLiteral("Save Slider Images");
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
    </div>
    <table class=""sportesTbl table table-striped table-dark"">
        <thead>
            <tr>
                <th>S NO.</th>
                <th>Id</th>
                <th>Image</th>
                <th>ACTION</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\Setting\SliderSetting.cshtml"
             if (Model != null)
            {
                int i = 1;
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td scope=\"row\">");
#nullable restore
#line 29 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\Setting\SliderSetting.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td scope=\"row\">");
#nullable restore
#line 30 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\Setting\SliderSetting.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><img style=\"height:50px; width:100px;\"");
            BeginWriteAttribute("src", " src=\"", 963, "\"", 986, 2);
            WriteAttributeValue("", 969, "../", 969, 3, true);
#nullable restore
#line 31 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\Setting\SliderSetting.cshtml"
WriteAttributeValue("", 972, item.FilePath, 972, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                        <td>\r\n                            <a data-value=\"");
#nullable restore
#line 33 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\Setting\SliderSetting.cshtml"
                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                               href=""javascript:void(0)"" class=""btnEdit"">
                                <div class=""row"">
                                    <div class=""col-3"">
                                        <span class=""switch switch-success"">
                                            <label>
                                                <input type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 1465, "\"", 1487, 1);
#nullable restore
#line 39 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\Setting\SliderSetting.cshtml"
WriteAttributeValue("", 1475, item.Status, 1475, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""select"" id=""checkBoxAction"" />
                                                <span></span>
                                            </label>
                                        </span>
                                    </div>
                                </div>
                            </a>
                        </td>
                    </tr>
");
#nullable restore
#line 48 "C:\Arun\Projects\RB444\rb444\RB444.Admin\Views\Setting\SliderSetting.cshtml"
                    i++;
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591