using System;
using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Models;
using RolêTopMVC.ViewModels;

namespace RolêTopMVC.Controllers
{
    public class Pacote2Controller : AbstractController
    {

        public IActionResult Index(PacoteViewModel pacoteViewModel)
        {
            pacoteViewModel.NomeView = "Pacote2";
            return View(pacoteViewModel);
        }
        public IActionResult Registrar(PacoteViewModel pacoteViewModel)
        {
            return RedirectToAction("Index","Login");
        }
    }
}