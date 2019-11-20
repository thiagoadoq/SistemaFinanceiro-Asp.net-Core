#pragma checksum "C:\PROJETOS\SistemaFinanceiro-Asp.net-Core\SistemaFinanceiro\Views\Acesso\TerceirosGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b103a0e66dffde77d0518cb848755b216f2d7f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Acesso_TerceirosGrid), @"mvc.1.0.view", @"/Views/Acesso/TerceirosGrid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Acesso/TerceirosGrid.cshtml", typeof(AspNetCore.Views_Acesso_TerceirosGrid))]
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
#line 1 "C:\PROJETOS\SistemaFinanceiro-Asp.net-Core\SistemaFinanceiro\Views\_ViewImports.cshtml"
using SistemaFinanceiro;

#line default
#line hidden
#line 2 "C:\PROJETOS\SistemaFinanceiro-Asp.net-Core\SistemaFinanceiro\Views\_ViewImports.cshtml"
using SistemaFinanceiro.Models;

#line default
#line hidden
#line 3 "C:\PROJETOS\SistemaFinanceiro-Asp.net-Core\SistemaFinanceiro\Views\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b103a0e66dffde77d0518cb848755b216f2d7f7", @"/Views/Acesso/TerceirosGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68eccfb344492a0da8f411ca996302faaade2f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Acesso_TerceirosGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Terceiros>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(35, 739, false);
#line 3 "C:\PROJETOS\SistemaFinanceiro-Asp.net-Core\SistemaFinanceiro\Views\Acesso\TerceirosGrid.cshtml"
Write(Html
        .Grid(Model)
        .Build(columns =>
        {
            columns.Add(model => model.Id).Css("collapse");
            columns.Add(model => model.Nome).Titled("NOME").Encoded(false).RenderedAs(model => "<a href='/Painel/TerceiroEditar/" + model.Id + "'>" + model.Nome + "</a>").InitialSort(GridSortOrder.Asc);
            columns.Add(model => model.Endereco).Titled("ENDEREÇO");
            columns.Add(Model => Model.Cpf).Titled("CPF");
           
        })
        .Css("table table-hover")
        .Filterable()
        .Sortable()
        .Pageable(pager =>
        {
            pager.PagesToDisplay = 5;
            pager.RowsPerPage = 10;
        })
        .Empty("Nenhum resultado encontrado")
);

#line default
#line hidden
            EndContext();
            BeginContext(775, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Terceiros>> Html { get; private set; }
    }
}
#pragma warning restore 1591