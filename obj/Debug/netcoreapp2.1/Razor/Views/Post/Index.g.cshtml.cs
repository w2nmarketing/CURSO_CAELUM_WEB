#pragma checksum "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c1ddf50a5a837cf095b6852568bf373a2bd74e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c1ddf50a5a837cf095b6852568bf373a2bd74e1", @"/Views/Post/Index.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 208, true);
            WriteLiteral("\r\n<h2>Lista dos Posts</h2>\r\n\r\n<hr />\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>TÍTULO</th>\r\n            <th>RESUMO</th>\r\n            <th>CATEGORIA</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 16 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Index.cshtml"
         foreach(var p in Model)
        {

#line default
#line hidden
            BeginContext(284, 39, true);
            WriteLiteral("        <tr>\r\n            <td> <strong>");
            EndContext();
            BeginContext(324, 8, false);
#line 19 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Index.cshtml"
                    Write(p.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(332, 34, true);
            WriteLiteral("</strong> </td>\r\n            <td> ");
            EndContext();
            BeginContext(367, 8, false);
#line 20 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Index.cshtml"
            Write(p.Resumo);

#line default
#line hidden
            EndContext();
            BeginContext(375, 25, true);
            WriteLiteral(" </td>\r\n            <td> ");
            EndContext();
            BeginContext(401, 11, false);
#line 21 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Index.cshtml"
            Write(p.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(412, 23, true);
            WriteLiteral(" </td>\r\n        </tr>\r\n");
            EndContext();
#line 23 "C:\Users\aspnet8437\Documents\MARCELO\Blog\Blog\Views\Post\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(446, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
