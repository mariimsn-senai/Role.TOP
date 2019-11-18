using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class CasaController : Controller
    {
        public IActionResult casa()
        {
            ViewData["NomeView"] = "Casa";
            return View();
        }
    }
}