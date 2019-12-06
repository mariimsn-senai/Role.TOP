using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Models;
using RolêTopMVC.Repositorio;
using RolêTopMVC.ViewModels;

namespace RolêTopMVC.Controllers
{

public class PedidoController : AbstractController
{
    ClienteRepository clienteRepository = new ClienteRepository();
    PedidoRepository pedidoRepository = new PedidoRepository();
    PacotesRepository pacotesRepository = new PacotesRepository();
    public IActionResult Index()
    {

        PedidoViewModel pvm = new PedidoViewModel();
        pvm.Pacote = pacotesRepository.ObterTodos();

        var usuarioLogado = ObterUsuarioSession();
        var nomeUsuarioLogado = ObterUsuarioNomeSession();
        if (!string.IsNullOrEmpty(nomeUsuarioLogado))
        {
            pvm.NomeCliente = nomeUsuarioLogado;
        }
        var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
        if (clienteLogado != null)
        {
            pvm.Cliente = clienteLogado;
        }
        pvm.NomeView = "Pedido";
        pvm.UsuarioEmail = usuarioLogado;
        pvm.UsuarioNome = nomeUsuarioLogado;

        return View(pvm);
    //}
    //public IActionResult Registrar(IFormCollection form)
    //{
        //List<Produto> listaPacotes = new List<Produto>();
        //ViewData["Action"] = "Pedido";
        //Pedido pedido = new Pedido();
        //var nomePacote = form["pacote"];
        // Pacote pacote = new Pacote (nomePacote,pacotesRepository.ObterPrecoDe(nomePacote));

        //PacoteSimples ps = new PacoteSimples();

        //agendamento agendamento = new agendamento();



        // Cliente cliente = new Cliente()
        //{
            //  Nome = form["nome"],
            //Endereco = form["endereco"],
            //Telefone = form["telefone"],
            //Email = form["email"]

        //};

    //uint é todos os numeros sem os negativos
    //codigo de pedido de aprovação e negação de pedido

        // }

    }

    public IActionResult Registrar (ulong id)
    {
        
    }

}

}