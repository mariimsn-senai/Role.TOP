#pragma checksum "C:\Users\44879682837\Documents\2s------Sprint4\RolêTopMVC\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dc362219610242d9afe8ba407f2f5cb4fd4fa0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login.cshtml", typeof(AspNetCore.Views_Login_Login))]
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
#line 1 "C:\Users\44879682837\Documents\2s------Sprint4\RolêTopMVC\Views\_ViewImports.cshtml"
using RolêTopMVC;

#line default
#line hidden
#line 2 "C:\Users\44879682837\Documents\2s------Sprint4\RolêTopMVC\Views\_ViewImports.cshtml"
using RolêTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dc362219610242d9afe8ba407f2f5cb4fd4fa0e", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259cbc5f9b7e6129e7f7a68c9e881e2d0a043075", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 242, true);
            WriteLiteral("<main>\r\n\r\n        <div id=\"gradient\">\r\n            \r\n\r\n            <section id=menu>\r\n                <header>\r\n            </header>\r\n        </section>\r\n        \r\n        <div class=\"formu\">\r\n            <br>\r\n            <br>\r\n            ");
            EndContext();
            BeginContext(242, 830, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dc362219610242d9afe8ba407f2f5cb4fd4fa0e3901", async() => {
                BeginContext(302, 763, true);
                WriteLiteral(@"
                <div id=lon>
                    <h1>Login</h1>
                    <p>Email:</p>
                    <p class=""email"">
                        <input type=""email"" name=""email"" placeholder=""Roletop@gmail.com"" required=""required"">
                    </p>
                    
                    <br>
                    <p>Senha:</p>
                    <p class=""Senha"">
                        <input type=""password"" name=""senha"" placeholder=""*********"" required=""required"">
                    </p>
                    <br>
                    <p class=""enviar"">
                        <input type=""submit"" name=""enviar"" value=""Enviar"">
                    </p>
                    <br>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 14 "C:\Users\44879682837\Documents\2s------Sprint4\RolêTopMVC\Views\Login\Login.cshtml"
AddHtmlAttributeValue("", 256, Url.Action("Login","Cliente"), 256, 30, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1072, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(1088, 2198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dc362219610242d9afe8ba407f2f5cb4fd4fa0e6800", async() => {
                BeginContext(1161, 2118, true);
                WriteLiteral(@"

                <div id=cadas>
                    <h1>Cadastro</h1>
                    
                    <p>Nome:</p>
                    <p class=""nome"">
                        <input type=""text"" name=""nome"" placeholder=""José Silva Filho"" required=""required"">
                    </p>
                    
                    <br>
                    <p>Idade:</p>
                    <p class=""idade"">
                        <input type=""text"" name=""idade"" placeholder=""10/03/2000"" required=""required"">
                    </p>
                    
                    <br>
                    <p>Email:</p>
                    <p class=""email"">
                        <input type=""email"" name=""email"" placeholder=""Roletop@gmail.com"" required=""required"">
                    </p>
                    
                    
                    <br>
                    <p>Telefone:</p>
                    <p class=""telefone"">
                        <input type=""tel"" name=""telefone"" pla");
                WriteLiteral(@"ceholder=""1199999-9999"" required=""required"">
                    </p>
                    
                    <br>
                    <p>Endereço:</p>
                    <p class=""Endereco"">
                        <input type=""text"" name=""endereco"" placeholder=""Rua luiz Paulo, 121"" required=""required"">
                    </p>
                    
                    <br>
                    <p>CPF:</p>
                    <p class=""CPF"">
                        <input type=""adress"" name=""CPF"" placeholder=""448596251-37"" required=""required"">
                    </p>
                    
                    <br>
                    <p>Senha:</p>
                    <p class=""Senha"">
                        <input type=""password"" name=""senha"" placeholder=""*********"" required=""required"">
                    </p>
                    
                    <br>
                    <p class=""enviar"">
                        <input type=""submit"" name=""enviar"" value=""Enviar"">
                ");
                WriteLiteral("    </p>\r\n                    \r\n                    <br>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 35 "C:\Users\44879682837\Documents\2s------Sprint4\RolêTopMVC\Views\Login\Login.cshtml"
AddHtmlAttributeValue("", 1116, Url.Action("CadastrarCliente", "Cadastro"), 1116, 43, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3286, 273, true);
            WriteLiteral(@"
                </div>
            
        </div>
        
        <br>
        
        <div class=""adm"">
            <a href=adm.html><input type=""submit"" name=""Página do administrador"" value=""Página do administrador""></a>
        </div>
        
    </main>");
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
