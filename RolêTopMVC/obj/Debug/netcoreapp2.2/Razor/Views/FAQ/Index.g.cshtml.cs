#pragma checksum "C:\Users\44879682837\Desktop\role 5\Role.TOP\RolêTopMVC\Views\FAQ\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f125b27132f0ce7039e8678113625d049a1db5e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FAQ_Index), @"mvc.1.0.view", @"/Views/FAQ/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FAQ/Index.cshtml", typeof(AspNetCore.Views_FAQ_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f125b27132f0ce7039e8678113625d049a1db5e3", @"/Views/FAQ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259cbc5f9b7e6129e7f7a68c9e881e2d0a043075", @"/Views/_ViewImports.cshtml")]
    public class Views_FAQ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 12, true);
            WriteLiteral("<main>\r\n    ");
            EndContext();
            BeginContext(12, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f125b27132f0ce7039e8678113625d049a1db5e33620", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 2 "C:\Users\44879682837\Desktop\role 5\Role.TOP\RolêTopMVC\Views\FAQ\Index.cshtml"
AddHtmlAttributeValue("", 40, Url.Action(), 40, 13, false);

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
            BeginContext(62, 2668, true);
            WriteLiteral(@"
  <section id='titulo'>
            <div>
                <h1>FAQ</h1>
                <br>
                <strong><p> Tem área de fumante?</strong>
                    <br>
                 Sim, temos área para fumantes.
                <br>
                <strong>Tem banheiro?</strong>
                    <br>
                    Temos dois banheiros
                <br>
                <strong>Como faço para comprar?</strong>
                    <br>
                    Em nosso site temos planos.
                <br>
                <strong>Tem camarim?</strong>
                   <br>
                    Sim, nos temos.
                <br>
                <strong>Como faço para visitar o salão?</strong>
                   <br>
                   É só entrar em contato conosco.
                <br>
                <strong>É feito um contrato?</strong>
                  <br>
                   Sim, para sua segurança nos fazemos um contrato.
                <br>
           ");
            WriteLiteral(@"     <strong>A decoração é inclusa?</strong>
                   <br>
                   Infelizmente não fazemos decorações.
                <br>
                <strong>Quantos pacotes tem para escolher?</strong>
                  <br>
                   Temos três pacotes, veja em nosso site.</p>
            </div>
        
            </section>  

            <script>
                    function toggleMobileMenu() {
                        var ul = document.querySelector(""nav ul"");
                        var commonButtons = document.querySelectorAll(""nav .bt-common-menu"");
                        var icon = document.querySelector("".icon > i"");
            
                        ul.classList.toggle(""mobile-mode"");
            
                        if (icon.classList.contains(""fa-bars"")) {
                            icon.classList.remove(""fa-bars"");
                            icon.classList.remove(""fa"");
            
                            icon.classList.add(""fas"");
   ");
            WriteLiteral(@"                         icon.classList.add(""fa-bars"");
                        } else {
                            icon.classList.remove(""fas"");
                            icon.classList.remove(""fa-bars"");
            
                            icon.classList.add(""fa"");
                            icon.classList.add(""fa-bars"");
                        }
            
                        for (var button of commonButtons) {
                            button.classList.toggle(""active"");
                        }
            
                    }
            
                </script>
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
