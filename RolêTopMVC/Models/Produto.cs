using System;
using System.Collections.Generic;

namespace RolêTopMVC.Models
{
    public class Produto
    {
        public string Nome {get;set;}
        public double Valor {get;set;}
        public string luz {get;set;}
        public string som {get;set;}

        public string data {get;set;}
        
        public string horario {get;set;}

        public Produto()
        {
            List<Produto> pacotes = new List <Produto>();
        }
    }
}