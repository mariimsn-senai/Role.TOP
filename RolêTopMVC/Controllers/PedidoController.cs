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
    PacotesRepository pacotesRepository = new PacotesRepository();

    public IActionResult Pacotes()
    {

    var ninguemLogdado = string.IsNullOrEmpty(ObterUsuarioTipoSession());
    if (!ninguemLogdado)
            {

            var produtos = pedidoRepository.ObterTodos();
            PedidoViewModel PedidoViewModel = new PedidoViewModel();

            foreach ( var produto in produtos)
            {
                switch(produto.ValorPacote)
                {
                    case (uint) ValorPacotes.PacoteSimples:
                        PedidoViewModel.PacoteSimples++;
                        PedidoViewModel.Produtos.Add(produto);
                    break;
                    case (uint) ValorPacotes.PacotePadrao:
                        PedidoViewModel.PacotePadrao++;
                        PedidoViewModel.Produtos.Add(produto);
                    break;
                    case (uint) ValorPacotes.PacotePremium:
                        PedidoViewModel.PacotePremium++;
                        PedidoViewModel.Produtos.Add(produto);
                        //deixar na lista de pedido pendente
                    break;
                }
            }
            PedidoViewModel.NomeView = "Pacotes";
            return View();
            }

    }
    public IActionResult Registrar (ulong id)
    {
        var produto = pedidoRepository.ObterPor(id);
    }




}
}
