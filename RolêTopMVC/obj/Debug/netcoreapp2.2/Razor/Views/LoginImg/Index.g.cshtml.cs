#pragma checksum "C:\Users\44879682837\Desktop\role 5\Role.TOP\RolêTopMVC\Views\LoginImg\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "905650c34ff21d7f2e46bdab0ff03f4d05510032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoginImg_Index), @"mvc.1.0.view", @"/Views/LoginImg/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LoginImg/Index.cshtml", typeof(AspNetCore.Views_LoginImg_Index))]
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
#line 1 "C:\Users\44879682837\Desktop\role 5\Role.TOP\RolêTopMVC\Views\_ViewImports.cshtml"
using RolêTopMVC;

#line default
#line hidden
#line 2 "C:\Users\44879682837\Desktop\role 5\Role.TOP\RolêTopMVC\Views\_ViewImports.cshtml"
using RolêTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905650c34ff21d7f2e46bdab0ff03f4d05510032", @"/Views/LoginImg/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259cbc5f9b7e6129e7f7a68c9e881e2d0a043075", @"/Views/_ViewImports.cshtml")]
    public class Views_LoginImg_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/login.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 51, true);
            WriteLiteral("<main>\r\n\r\n        <div id=\"gradient\">\r\n            ");
            EndContext();
            BeginContext(51, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "905650c34ff21d7f2e46bdab0ff03f4d055100324563", async() => {
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
            EndContext();
            BeginContext(111, 191, true);
            WriteLiteral("\r\n\r\n            <section id=menu>\r\n                <header>\r\n            </header>\r\n        </section>\r\n        \r\n        <div class=\"formu\">\r\n            <br>\r\n            <br>\r\n            ");
            EndContext();
            BeginContext(302, 830, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "905650c34ff21d7f2e46bdab0ff03f4d055100326035", async() => {
                BeginContext(362, 763, true);
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
#line 14 "C:\Users\44879682837\Desktop\role 5\Role.TOP\RolêTopMVC\Views\LoginImg\Index.cshtml"
AddHtmlAttributeValue("", 316, Url.Action("Login","Cliente"), 316, 30, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1132, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(1148, 2197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "905650c34ff21d7f2e46bdab0ff03f4d055100328935", async() => {
                BeginContext(1220, 2118, true);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 35 "C:\Users\44879682837\Desktop\role 5\Role.TOP\RolêTopMVC\Views\LoginImg\Index.cshtml"
AddHtmlAttributeValue("", 1176, Url.Action("CadastroCliente", "Cadastro"), 1176, 42, false);

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
            BeginContext(3345, 273, true);
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
