using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class PacoteController : Controller
    {
        public IActionResult pacote()
        {
            ViewData["NomeView"] = "Pacote";
            return View();
        }
    }
}