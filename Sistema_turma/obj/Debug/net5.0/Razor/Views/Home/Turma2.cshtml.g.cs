#pragma checksum "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a09bab29d6c3675500445ac1dcc9ba798f1457f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Turma2), @"mvc.1.0.view", @"/Views/Home/Turma2.cshtml")]
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
#line 1 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\_ViewImports.cshtml"
using Sistema_turma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\_ViewImports.cshtml"
using Sistema_turma.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a09bab29d6c3675500445ac1dcc9ba798f1457f0", @"/Views/Home/Turma2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e86c3ec6a59171269152bdf36d12ecdee4e44594", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Turma2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Nota (prova1)</th>
            <th scope=""col"">Nota (prova2)</th>
            <th scope=""col"">Nota (prova3)</th>
            <th scope=""col"">Média</th>
            <th scope=""col"">Situação</th>
            <th scope=""col"">Nota (Prova final)</th>
            <th scope=""col"">Média Final</th>
            <th scope=""col"">Situação Final</th>
        </tr>
    </thead>
");
#nullable restore
#line 18 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
     foreach(Alunos a in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>");
#nullable restore
#line 22 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
           Write(a.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
           Write(a.Nota1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
           Write(a.Nota2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
           Write(a.Nota3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
           Write(a.Media.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
           Write(a.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
           Write(a.NotaFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
           Write(a.MediaFinal.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
           Write(a.MensagemFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\fesco\OneDrive\Área de Trabalho\Sistema_turma\Views\Home\Turma2.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
