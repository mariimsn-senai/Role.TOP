using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Models;

namespace RolêTopMVC.Controllers
{
    public class AdmController : AbstractController
    {
        public IActionResult Index()
        {
            return View(new AgendamentoViewModel (){
                NomeView = "ADM"
            });
        }
    }
}