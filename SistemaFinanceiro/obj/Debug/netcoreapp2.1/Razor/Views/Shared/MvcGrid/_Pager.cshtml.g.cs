#pragma checksum "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d2fab4c8ffb7faa456e03b0c86977bd89093deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MvcGrid__Pager), @"mvc.1.0.view", @"/Views/Shared/MvcGrid/_Pager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MvcGrid/_Pager.cshtml", typeof(AspNetCore.Views_Shared_MvcGrid__Pager))]
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
#line 1 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\_ViewImports.cshtml"
using SistemaFinanceiro;

#line default
#line hidden
#line 2 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\_ViewImports.cshtml"
using SistemaFinanceiro.Models;

#line default
#line hidden
#line 1 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d2fab4c8ffb7faa456e03b0c86977bd89093deb", @"/Views/Shared/MvcGrid/_Pager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68eccfb344492a0da8f411ca996302faaade2f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MvcGrid__Pager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IGridPager>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
  
    Int32 totalPages = Model.TotalPages;
    Int32 currentPage = Model.CurrentPage;
    Int32 firstDisplayPage = Model.FirstDisplayPage;

#line default
#line hidden
            BeginContext(197, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 203, "\"", 243, 2);
            WriteAttributeValue("", 211, "mvc-grid-pager", 211, 14, true);
#line 10 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue(" ", 225, Model.CssClasses, 226, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(244, 23, true);
            WriteLiteral(" data-show-page-sizes=\"");
            EndContext();
            BeginContext(268, 19, false);
#line 10 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                                               Write(Model.ShowPageSizes);

#line default
#line hidden
            EndContext();
            BeginContext(287, 4, true);
            WriteLiteral("\">\r\n");
            EndContext();
#line 11 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
     if (totalPages > 0)
    {
        if (currentPage > 1)
        {

#line default
#line hidden
            BeginContext(365, 111, true);
            WriteLiteral("            <button type=\"button\" data-page=\"1\">&laquo;</button>\r\n            <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(478, 15, false);
#line 16 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                         Write(currentPage - 1);

#line default
#line hidden
            EndContext();
            BeginContext(494, 21, true);
            WriteLiteral("\">&lsaquo;</button>\r\n");
            EndContext();
#line 17 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(551, 167, true);
            WriteLiteral("            <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&laquo;</button>\r\n            <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&lsaquo;</button>\r\n");
            EndContext();
#line 22 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        for (Int32 page = firstDisplayPage; page <= totalPages && page < firstDisplayPage + Model.PagesToDisplay; page++)
        {
            if (page == currentPage)
            {

#line default
#line hidden
            BeginContext(916, 64, true);
            WriteLiteral("                <button type=\"button\" class=\"active\" data-page=\"");
            EndContext();
            BeginContext(982, 4, false);
#line 27 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                                            Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(987, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(991, 4, false);
#line 27 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                                                     Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(996, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 28 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1055, 49, true);
            WriteLiteral("                <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(1106, 4, false);
#line 31 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                             Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1111, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1115, 4, false);
#line 31 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                                      Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1120, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 32 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
            }
        }
        if (currentPage < totalPages)
        {

#line default
#line hidden
            BeginContext(1207, 45, true);
            WriteLiteral("            <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(1254, 15, false);
#line 36 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                         Write(currentPage + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1270, 66, true);
            WriteLiteral("\">&rsaquo;</button>\r\n            <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(1337, 10, false);
#line 37 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                        Write(totalPages);

#line default
#line hidden
            EndContext();
            BeginContext(1347, 20, true);
            WriteLiteral("\">&raquo;</button>\r\n");
            EndContext();
#line 38 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1403, 167, true);
            WriteLiteral("            <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&rsaquo;</button>\r\n            <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&raquo;</button>\r\n");
            EndContext();
#line 43 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        if (Model.ShowPageSizes)
        {

#line default
#line hidden
            BeginContext(1626, 47, true);
            WriteLiteral("            <div class=\"mvc-grid-page-sizes\">\r\n");
            EndContext();
#line 47 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                 if (Model.PageSizes.Count > 0)
                {

#line default
#line hidden
            BeginContext(1741, 58, true);
            WriteLiteral("                    <select class=\"mvc-grid-pager-rows\">\r\n");
            EndContext();
#line 50 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                         foreach (KeyValuePair<Int32, String> size in Model.PageSizes)
                        {
                            if (Model.RowsPerPage == size.Key)
                            {

#line default
#line hidden
            BeginContext(2009, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2041, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ccd06a8198842d994cfdcbe3e2c1021", async() => {
                BeginContext(2077, 10, false);
#line 54 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                                              Write(size.Value);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 54 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                   WriteLiteral(size.Key);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            EndContext();
            BeginContext(2096, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2194, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2226, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ede2c63d1fc94d8492bd803f95f9d13f", async() => {
                BeginContext(2253, 10, false);
#line 58 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                                     Write(size.Value);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 58 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                                   WriteLiteral(size.Key);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2272, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 59 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(2332, 31, true);
            WriteLiteral("                    </select>\r\n");
            EndContext();
#line 62 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2423, 54, true);
            WriteLiteral("                    <input class=\"mvc-grid-pager-rows\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2477, "\"", 2503, 1);
#line 65 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2485, Model.RowsPerPage, 2485, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2504, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 66 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
                }

#line default
#line hidden
            BeginContext(2528, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 68 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2584, 60, true);
            WriteLiteral("            <input class=\"mvc-grid-pager-rows\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2644, "\"", 2670, 1);
#line 71 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2652, Model.RowsPerPage, 2652, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2671, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 72 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2711, 56, true);
            WriteLiteral("        <input class=\"mvc-grid-pager-rows\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2767, "\"", 2793, 1);
#line 76 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2775, Model.RowsPerPage, 2775, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2794, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 77 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Shared\MvcGrid\_Pager.cshtml"
    }

#line default
#line hidden
            BeginContext(2806, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IGridPager> Html { get; private set; }
    }
}
#pragma warning restore 1591
