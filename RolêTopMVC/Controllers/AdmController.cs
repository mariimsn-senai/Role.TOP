using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Enums;
using RolêTopMVC.Models;
using RolêTopMVC.Repositorio;
using RolêTopMVC.ViewModels;

namespace RolêTopMVC.Controllers
{
    public class AdmController : AbstractController
    {
        ProdutoRepository ProdutoRepository = new ProdutoRepository();
        public IActionResult Index()
        {
            return View(new DashboardViewModel (){
                NomeView = "ADM"
            });
        }

        public IActionResult Dashboard()
        {
            var ninguemLogdado = string.IsNullOrEmpty(ObterUsuarioTipoSession());
            
            if (!ninguemLogdado || (uint) TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {

            var pedidos = ProdutoRepository.ObterTodos();
            DashboardViewModel dashbordViewModel = new DashboardViewModel();

            foreach ( var pedido in pedidos)
            {
                switch(pedido.Status)
                {
                    case (uint) StatusPedido.ACEITAR:
                        dashbordViewModel.Aceitar++;
                    break;

                    case
                        (uint) StatusPedido.RECUSAR:
                        dashbordViewModel.Recusar++;
                        // //deixar na lista de pedido pendente
                    break;
                    default:
                        dashbordViewModel.Pendente++;
                        dashbordViewModel.Produto.Add(pedido);
                        //deixar na lista de pedido pendente
                    break;
                }
            }
            dashbordViewModel.NomeView = "Dashboard";
            dashbordViewModel.UsuarioEmail = ObterUsuarioSession();
            return View(dashbordViewModel);
            }
            else
            {
                return View ("Erro", new RespostasViewModel(){
                NomeView = "Dashboard",
                Mensagem = "Você não tem permissão para acessar o Dashboard"

                });
            }
        }
    }
}