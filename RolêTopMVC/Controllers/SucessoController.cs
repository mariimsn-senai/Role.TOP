using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class SucessoController : Controller
    {
    public IActionResult Sucesso()
        {
            ViewData["NomeView"] = "Sucesso";
            return View();
        }
    }
}