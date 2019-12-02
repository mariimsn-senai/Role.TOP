using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Models;
using RolêTopMVC.Repositorio;

namespace RolêTopMVC.Controllers
{
    public class CadastroController : Controller
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {    
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try
            {
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["idade"],
                    form["email"],
                    form["telefone"],
                    form["endereco"],
                    form["CPF"],
                    form["senha"]
                    );
                    
                    clienteRepository.Inserir(cliente);
                    return RedirectToAction("Sucesso","Sucesso");
                

            }catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");

            }

        }
    }
}