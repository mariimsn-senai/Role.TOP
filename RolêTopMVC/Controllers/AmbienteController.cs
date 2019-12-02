using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class AmbienteController : Controller
    {
        public IActionResult Ambiente()
        {
            ViewData["NomeView"] = "Ambiente";
            return View();
        }
    }
}