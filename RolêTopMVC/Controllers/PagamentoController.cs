using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Enums;
using RolêTopMVC.Models;
using RolêTopMVC.Repositorio;
using RolêTopMVC.ViewModels;

namespace RolêTopMVC.Controllers
{
    public class PagamentoController : AbstractController
    {
        ProdutoRepository pr = new ProdutoRepository();
        public IActionResult Index(AgendamentoViewModel avm)
        {
            avm.NomeView = "Pagamento";
            return View(avm);
        }

        public IActionResult GravarPedido (IFormCollection form)
        {
            PagamentoViewModel pagamentoViewModel = new PagamentoViewModel();
            Pagamento pagamento = new Pagamento(
                form["parcelas"]
            );
            var id_pacote = int.Parse(form["id_pacote"]);
            switch (id_pacote)
            {
                case (int) ValorPacotes.PacoteSimples:
                pagamento.Nome = "Pacote Simples";
                break;
                case (int) ValorPacotes.PacotePadrao:
                pagamento.Nome = "Pacote Padrão";
                break;
                case (int) ValorPacotes.PacotePremium:
                pagamento.Nome = "Pacote Premium";
                break;
                default:
                break;
                
            }
            pagamentoViewModel.Parcelas = pagamento.parcelas;
            pagamentoViewModel.CodigoPacote = id_pacote;
            pagamentoViewModel.data = form["id_data"];
            pagamentoViewModel.horario = form["id_horario"];

            pagamento.Id = ulong.Parse(form["id_pacote"]);
            pagamento.data = form["id_data"];
            pagamento.horario = form["id_horario"];

            if(pr.Inserir(pagamento))
            {
            return RedirectToAction("Index","PaginaDeSucesso", pagamentoViewModel);
                
            }
            else{
                return RedirectToAction("Erro", new RespostasViewModel(){
                    NomeView = "Agendamento",
                    Mensagem = "não foi a porra do inserir"
                });
            }
        }
    }
}