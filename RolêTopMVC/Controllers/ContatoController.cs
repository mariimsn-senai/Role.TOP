using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class ContatoController : Controller
    {
        
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Contato";
            return View();
        }
    }
}