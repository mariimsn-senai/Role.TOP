using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Models;
using RolêTopMVC.ViewModels;

namespace RolêTopMVC.Controllers
{
    public class PagamentoController : AbstractController
    {
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
            pagamentoViewModel.Parcelas = pagamento.parcelas;
            pagamentoViewModel.CodigoPacote = int.Parse(form["id_pacote"]);
            pagamentoViewModel.data = form["id_data"];
            pagamentoViewModel.horario = form["id_horario"];
            return RedirectToAction("Index","PaginaDeSucesso", pagamentoViewModel);
        }
    }
}