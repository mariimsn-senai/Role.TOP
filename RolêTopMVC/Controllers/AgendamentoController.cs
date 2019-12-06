using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Models;

namespace RolêTopMVC.Controllers
{
    public class AgendamentoController : Controller
    {
        public IActionResult Index(AgendamentoViewModel agendamentoViewModel)
        {
            ViewData["NomeView"] = "Agendamento";
            return View(agendamentoViewModel);
        }
    }
}