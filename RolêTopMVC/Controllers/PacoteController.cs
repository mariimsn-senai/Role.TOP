using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class PacoteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Pacote";
            return View();
        }
    }
}