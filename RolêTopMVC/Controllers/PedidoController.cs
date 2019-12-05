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
        }
        public IActionResult Registrar(IFormCollection form)
        {
            List<Produto> listaPacotes = new List<Produto>();
            ViewData["Action"] = "Pedido";
            Pedido pedido = new Pedido();
            var nomePacote = form["pacote"];
            // Pacote pacote = new Pacote (nomePacote,pacotesRepository.ObterPrecoDe(nomePacote));

            PacoteSimples ps = new PacoteSimples();

            agendamento agendamento = new agendamento();



            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]

            };


            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;


            if (pedidoRepository.Inserir(pedido))
            {
                return View("Sucesso", new RespostasViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });

            }
            else
            {
                return View("Erro", new RespostasViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });


            }
        }

        //uint é todos os numeros sem os negativos
        //codigo de pedido de aprovação e negação de pedido
        public IActionResult Aprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);

            if (pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Adm", "Adm");
            }
            else
            {
                return View("Erro", new RespostasViewModel("Não foi possível aprovar este pedido")
                {
                    NomeView = "Adm",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Reprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);

            if (pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Adm", "Adm");
            }
            else
            {
                return View("Erro", new RespostasViewModel("Não foi possível reprovar este pedido")
                {
                    NomeView = "Adm",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}