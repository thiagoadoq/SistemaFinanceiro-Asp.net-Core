#pragma checksum "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e7651ea75d0f1b22900789ada832b5e61c109f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Financeiro_Index), @"mvc.1.0.view", @"/Views/Financeiro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Financeiro/Index.cshtml", typeof(AspNetCore.Views_Financeiro_Index))]
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
#line 3 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e7651ea75d0f1b22900789ada832b5e61c109f", @"/Views/Financeiro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68eccfb344492a0da8f411ca996302faaade2f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Financeiro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaFinanceiro.Models.Financeriros>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ebb5d9d72b43ab890a75c7f07c464f", async() => {
                BeginContext(152, 9, true);
                WriteLiteral("Adicionar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(165, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(258, 38, false);
#line 16 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(296, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(352, 47, false);
#line 19 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TerceirosId));

#line default
#line hidden
            EndContext();
            BeginContext(399, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(455, 48, false);
#line 22 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(503, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(559, 50, false);
#line 25 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataReferencia));

#line default
#line hidden
            EndContext();
            BeginContext(609, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(665, 45, false);
#line 28 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(710, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(766, 41, false);
#line 31 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(807, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(925, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(974, 37, false);
#line 40 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1067, 46, false);
#line 43 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TerceirosId));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1169, 47, false);
#line 46 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1272, 49, false);
#line 49 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataReferencia));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1377, 44, false);
#line 52 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1421, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1477, 40, false);
#line 55 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1573, 53, false);
#line 58 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 38, true);
            WriteLiteral(" |\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 61 "C:\Projetos\financeiro-construtora\SistemaFinanceiro\Views\Financeiro\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1667, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaFinanceiro.Models.Financeriros>> Html { get; private set; }
    }
}
#pragma warning restore 1591
