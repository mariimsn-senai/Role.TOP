using System.Collections.Generic;
using RolêTopMVC.Models;

namespace RolêTopMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        
        public List<Produto> Produtos {get;set;}
        public uint PacoteSimples {get;set;}
        public uint PacotePadrao {get;set;}
        public uint PacotePremium {get;set;}

        public PedidoViewModel()
        {
            this.Produtos = new List<Produto>();
        }
    }
}
