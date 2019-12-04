using System.Collections.Generic;
using RolêTopMVC.Models;

namespace RolêTopMVC.ViewModels
{
            public class PedidoViewModel : BaseViewModel
    {
        public List<Pacote> Pacote {get;set;}
        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}

        public PedidoViewModel()
        {
            this.Pacote = new List<Pacote>();
            this.Cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }
    }
}