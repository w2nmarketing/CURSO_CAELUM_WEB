#pragma checksum "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Novo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e2247966daf9b6639a3844c4087cc8ee479a939"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2247966daf9b6639a3844c4087cc8ee479a939", @"/Views/Post/Novo.cshtml")]
    public class Views_Post_Novo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 127, true);
            WriteLiteral("\r\n<h2>Novo</h2>\r\n\r\n<hr />\r\n\r\n<a href=\"/post\">Listar Todos</a>\r\n\r\n<hr />\r\n\r\n<form method=\"POST\" action=\"/post/adiciona\">\r\n\r\n    ");
            EndContext();
            BeginContext(153, 24, false);
#line 13 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(177, 74, true);
            WriteLiteral("\r\n\r\n    <label>\r\n        Título:\r\n        <input type=\"text\" name=\"Titulo\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 251, "\"", 272, 1);
#line 17 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Novo.cshtml"
WriteAttributeValue("", 259, Model.Titulo, 259, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(273, 50, true);
            WriteLiteral(" maxlength=\"100\" required />\r\n    </label>\r\n\r\n    ");
            EndContext();
            BeginContext(324, 32, false);
#line 20 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.ValidationMessage("Titulo"));

#line default
#line hidden
            EndContext();
            BeginContext(356, 88, true);
            WriteLiteral("\r\n\r\n    <hr />\r\n\r\n    <label>\r\n        Resumo:\r\n        <input type=\"text\" name=\"Resumo\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 444, "\"", 465, 1);
#line 26 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Novo.cshtml"
WriteAttributeValue("", 452, Model.Resumo, 452, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(466, 50, true);
            WriteLiteral(" maxlength=\"200\" required />\r\n    </label>\r\n\r\n    ");
            EndContext();
            BeginContext(517, 32, false);
#line 29 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.ValidationMessage("Resumo"));

#line default
#line hidden
            EndContext();
            BeginContext(549, 94, true);
            WriteLiteral("\r\n\r\n    <hr />\r\n\r\n    <label>\r\n        Categoria:\r\n        <input type=\"text\" name=\"Categoria\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 643, "\"", 667, 1);
#line 35 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Novo.cshtml"
WriteAttributeValue("", 651, Model.Categoria, 651, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(668, 49, true);
            WriteLiteral(" maxlength=\"50\" required />\r\n    </label>\r\n\r\n    ");
            EndContext();
            BeginContext(718, 35, false);
#line 38 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.ValidationMessage("Categoria"));

#line default
#line hidden
            EndContext();
            BeginContext(753, 99, true);
            WriteLiteral("\r\n\r\n    <hr />\r\n\r\n    <button name=\"Enviar\" value=\"sim\">Enviar Cadastro</button>\r\n\r\n</form>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(852, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc5f4b8e8f0a4983b3c49ae2bf0bf02c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(903, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(905, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358ce2d6a1e64656985878d2cb4e93a6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(976, 54, true);
            WriteLiteral("\r\n\r\n<script>\r\n    $(\"form\").validate();\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
