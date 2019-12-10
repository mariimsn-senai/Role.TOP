using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Enums;
using RolêTopMVC.Models;
using RolêTopMVC.Repositorio;
using RolêTopMVC.ViewModels;
using static RolêTopMVC.ViewModels.PedidoViewModel;

namespace RolêTopMVC.Controllers
{

    public class PedidoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
    
        public IActionResult Registrar(int id)
        {
            AgendamentoViewModel avm= new AgendamentoViewModel();

            // switch (id)
            // {
            //     case (int) ValorPacotes.PacoteSimples:
            //         avm.NomeView = "Simples";
            //         PacoteSimples ps = new PacoteSimples();
            //         avm.PacoteSimples = ps;
            //         break;
            //     case (int) ValorPacotes.PacotePadrao:
            //         avm.NomeView = "Padrao";
            //         PacotePadrao pp = new PacotePadrao();
            //         avm.PacotePadrao = pp;
            //         break;
            //     case (int )ValorPacotes.PacotePremium:
            //         avm.NomeView = "Premium";
            //         PacotePremium prep = new PacotePremium();
            //         avm.PacotePremium = prep;
            //         break;
            // }

            avm.CodigoPacote = id;
            return RedirectToAction("Index","Agendamento", avm);
        }

    }
}
