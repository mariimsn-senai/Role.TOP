namespace RolêTopMVC.Models
{
    public class Produto
    {
        public class PacoteSimples()
        {
            
            public string PacoteSimples {get;set;}
            public string Pacote1 {get;set;}
            public double Valor {get;set;}

        }

        public PacoteSimples()
        {

        }
        
        public PacoteSimples(string PacoteSimples, string Pacote1, double Valor)
        {
            this.PacoteSimples = PacoteSimples;
            this.Pacote1 = Pacote1;
            this.Valor = Valor;
        }

        public class PacotePadrao()
        {
            public string PacotePadrao {get;set;}
            public string Pacote2 {get;set;}
            public double Valor {get;set;}
        }

        public PacotePadrao()
        {

        }

        public PacotePadrao(string PacotePadrao, string Pacote2, double Valor)
        {
            this.PacotePadrao = PacotePadrao;
            this.Pacote2 = Pacote2;
            this.Valor = Valor;
        }

        public class PacotePremium()
        {
            public string PacotePremium {get;set;}
            public string Pacote3 {get;set;}
            public double Valor {get;set;}
        }

        public PacotePremium()
        {

        }
        
        public PacotePremium(string PacotePremium, string Pacote3, double Valor)
        {
            this.PacotePremium = PacotePremium;
            this.Pacote3 = Pacote3;
            this.Valor = Valor;
        }
    }
}