#pragma checksum "C:\Users\44879682837\Desktop\role 4\Role.TOP\RolêTopMVC\Views\Pacote\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8a86a6c8df722d1718b7ababc2860ef200dcad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacote_Index), @"mvc.1.0.view", @"/Views/Pacote/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pacote/Index.cshtml", typeof(AspNetCore.Views_Pacote_Index))]
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
#line 1 "C:\Users\44879682837\Desktop\role 4\Role.TOP\RolêTopMVC\Views\_ViewImports.cshtml"
using RolêTopMVC;

#line default
#line hidden
#line 2 "C:\Users\44879682837\Desktop\role 4\Role.TOP\RolêTopMVC\Views\_ViewImports.cshtml"
using RolêTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8a86a6c8df722d1718b7ababc2860ef200dcad3", @"/Views/Pacote/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259cbc5f9b7e6129e7f7a68c9e881e2d0a043075", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacote_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RolêTopMVC.ViewModels.PacoteViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 762, true);
            WriteLiteral(@"<main>
            <section id=""tudo"">
                <div>
                    <h1>Pacotes</h1>
                </div>
                    
                    <label class=""tex"" for=""PacoteSimples""></div>
                        <p>   
                        <b><label class=""tex"" for=""PacoteSimples"" >Pacote Simples</label></b>
                        <input type=""hidden"" name=""PacoteSimples"" />
                        <br> 
                        <br>
                        <br>
                        <p>Alugar o espaço</p>
                        <br>
                        <br>
                        <br>
                        <p>Valor:10,000R$</p>
                        <br>
                        <br>
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 808, "\'", 888, 1);
#line 22 "C:\Users\44879682837\Desktop\role 4\Role.TOP\RolêTopMVC\Views\Pacote\Index.cshtml"
WriteAttributeValue("", 815, Url.Action("Registrar", "Pedido", new {id = @Model.CodigoPacoteSimples}), 815, 73, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(889, 913, true);
            WriteLiteral(@" method=""GET"" class=""pacotes"">
                        <input type=""submit"" class=""compra""><b>Compre já!</a></b></div> 
                        </p>
                    </div>
                    </a>
                    
                    <label class=""tex"" for=""PacotePadrao""></div>
                        <p>
                        <b><label class=""tex"" for=""PacotePadrao"" >Pacote Padrao</label></b>
                        <input type=""hidden"" name=""PacotePadrao""/>
                        <br>
                        <br>
                        <p>Alugar o espaço
                        <br>
                        mais o som
                        <br>
                        ou a luz.</p>
                        <br>
                        <br>
                        <p>Valor: 15,000R$</p>
                        <br>
                        <br>
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1802, "\'", 1881, 1);
#line 44 "C:\Users\44879682837\Desktop\role 4\Role.TOP\RolêTopMVC\Views\Pacote\Index.cshtml"
WriteAttributeValue("", 1809, Url.Action("Registrar", "Pedido", new {id = @Model.CodigoPacotePadrao}), 1809, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1882, 875, true);
            WriteLiteral(@" method=""GET"" class=""pacotes"">
                        <input type=""submit"" class=""compra"" ><b>Compre já!</a></b></div> 
                    </div>
                    </a>
        
                    <label class=""tex"" for=""PacotePremium""></div>
                        <p>
                        <b><label class=""tex"" for=""PacotePremium"" >Pacote Premium</label></b>
                        <input type=""hidden"" name=""PacotePremium""/>
                        <br>
                        <br>
                        <p>Alugar o espaço
                        <br>
                        mais o som
                        <br>
                        e a luz.</p>
                        <br>
                        <br>
                        <p>Valor: 20,000R$</p>
                        <br>
                        <br>
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2757, "\'", 2837, 1);
#line 65 "C:\Users\44879682837\Desktop\role 4\Role.TOP\RolêTopMVC\Views\Pacote\Index.cshtml"
WriteAttributeValue("", 2764, Url.Action("Registrar", "Pedido", new {id = @Model.CodigoPacotePremium}), 2764, 73, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2838, 282, true);
            WriteLiteral(@" method=""GET"" class=""pacotes"">
                        <input type=""submit"" class=""compra"" ><b>Compre já!</a></b></div> 
                        </div> 
                        </a>
                    </div> 
                </div>
            </section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RolêTopMVC.ViewModels.PacoteViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
