using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class ContatoController : Controller
    {
        
        public IActionResult Contato()
        {
            ViewData["NomeView"] = "Contato";
            return View();
        }
    }
}