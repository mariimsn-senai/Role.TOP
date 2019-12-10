using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Models;
using RolêTopMVC.ViewModels;

namespace RolêTopMVC.Controllers
{
    public class PacoteController : AbstractController
    {
        public IActionResult Index(PacoteViewModel pacoteViewModel)
        {
            pacoteViewModel.NomeView = "Pacote";
            return View(pacoteViewModel);
        }

        

    }
}