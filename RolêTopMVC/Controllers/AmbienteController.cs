using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class AmbienteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Ambiente";
            return View();
        }
    }
}