#pragma checksum "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Novo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0616e2e0cc73d88a0f0782bffa9161ba4c32c984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Novo), @"mvc.1.0.view", @"/Views/Post/Novo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Novo.cshtml", typeof(AspNetCore.Views_Post_Novo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0616e2e0cc73d88a0f0782bffa9161ba4c32c984", @"/Views/Post/Novo.cshtml")]
    public class Views_Post_Novo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 540, true);
            WriteLiteral(@"<h2>Novo</h2>

<form method=""POST"" action=""/post/adiciona"">

    <label>
        Título:
        <input type=""text"" name=""Titulo"" value="""" maxlength=""50"" />
    </label>

    <hr />

    <label>
        Resumo:
        <input type=""text"" name=""Resumo"" value="""" maxlength=""200"" />
    </label>

    <hr />


    <label>
        Categoria:
        <input type=""text"" name=""Categoria"" value="""" maxlength=""20"" />
    </label>

    <hr />


    <button name=""Enviar"" value=""sim"">Enviar Cadastro</button>

</form>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
