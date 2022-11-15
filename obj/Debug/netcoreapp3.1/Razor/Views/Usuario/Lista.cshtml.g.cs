[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Lista), @"mvc.1.0.view", @"/Views/Usuario/Lista.cshtml")]
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

using CadastroCRUD;
using CadastroCRUD.Models;

    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aacae1aa2d752c06ad2e4f1af26e9cc9e3611c20", @"/Views/Usuario/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bccc5751ed720b49de067d6c07925191f1f5ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {

    ViewData["Title"] = "Lista";

            WriteLiteral("\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nome</th>\r\n            <th>Login</th>\r\n            <th>Senha</th>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n");

         foreach (Usuario u in Model)
        {

            WriteLiteral("            <tr>\r\n                <td>");
               Write(u.Id);

            WriteLiteral("</td>\r\n                <td>");
               Write(u.Nome);

            WriteLiteral("</td>\r\n                <td>");
               Write(u.Login);

            WriteLiteral("</td>\r\n                <td>");
               Write(u.Senha);

            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 521, "\"", 552, 2);
            WriteAttributeValue("", 528, "/Usuario/Editar?Id=", 528, 19, true);
WriteAttributeValue("", 547, u.Id, 547, 5, false);

            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 588, "\"", 620, 2);
            WriteAttributeValue("", 595, "/Usuario/Remover?Id=", 595, 20, true);
WriteAttributeValue("", 615, u.Id, 615, 5, false);

            EndWriteAttribute();
            WriteLiteral(">Remover</a>\r\n                </td>\r\n            </tr>\r\n");
        }

            WriteLiteral("    <tbody>\r\n\r\n    </tbody>\r\n</table>");
        }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}