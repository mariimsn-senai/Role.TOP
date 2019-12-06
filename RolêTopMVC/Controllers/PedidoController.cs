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
        PedidoRepository pedidoRepository = new PedidoRepository();
        


        public IActionResult Registrar(ulong id)
        {
            AgendamentoViewModel agendamentoViewModel= new AgendamentoViewModel();

            switch (id)
            {
                case (uint)ValorPacotes.PacoteSimples:
                    PacoteSimples ps = new PacoteSimples();
                    agendamentoViewModel.PacoteSimples = ps;
                    break;
                case (uint)ValorPacotes.PacotePadrao:
                    PacotePadrao pp = new PacotePadrao();
                    agendamentoViewModel.PacotePadrao = pp;
                    break;
                case (uint)ValorPacotes.PacotePremium:
                    PacotePremium prep = new PacotePremium();
                    agendamentoViewModel.PacotePremium = prep;
                    break;
            }
            return RedirectToAction("Index","Agendamento", agendamentoViewModel);
        }

    }
}
