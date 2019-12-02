using System;

namespace RolêTopMVC.Models
{
    public class Pedido
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public Pacote Pacote {get;set;}
        public DateTime DataDoPedido {get;set;}

    }
}