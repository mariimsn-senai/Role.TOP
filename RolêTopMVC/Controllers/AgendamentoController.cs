using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Models;
using RolêTopMVC.ViewModels;
using RolêTopMVC.Enums;

namespace RolêTopMVC.Controllers
{
    public class AgendamentoController : AbstractController
    {
        public IActionResult Index(AgendamentoViewModel agendamentoViewModel)
        {
            agendamentoViewModel.NomeView = "Agendamento";
            return View(agendamentoViewModel);
        }
        
        public IActionResult GravarEvento (IFormCollection form)
        {
            //var id = uint.Parse(form["id_pacote"]);
            //if(id == ValorPacotes.PacoteSimples){

            //}
            AgendamentoViewModel agendamentoViewModel = new AgendamentoViewModel();
            Agendamento agendamento = new Agendamento(
                form["data"],
                form["horario"]
            );
            agendamentoViewModel.data = agendamento.data;
            agendamentoViewModel.horario = agendamento.horario;
            
            agendamentoViewModel.CodigoPacote = int.Parse(form["id_pacote"]);
            return RedirectToAction("Index","Pagamento", agendamentoViewModel);
        }
    }
}