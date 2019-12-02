using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class AdmController : Controller
    {
        public IActionResult Adm()
        {
            ViewData["NomeView"] = "ADM";
            return View();
        }
    }
}