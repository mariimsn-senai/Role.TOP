using System.Collections.Generic;
using RolêTopMVC.Models;

namespace RolêTopMVC.ViewModels
{
            public class PedidoViewModel : BaseViewModel
    {
        public List<Produto> Pacote {get;set;}
        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}

        public PedidoViewModel()
        {
            this.Pacote = new List<Produto>();
            this.Cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }
    }
}