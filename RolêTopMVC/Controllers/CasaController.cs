using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class CasaController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}