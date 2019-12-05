namespace RolêTopMVC.Models
{
    public class PacotePremium : Produto
    {
        public PacotePremium()
        {

        }

        public PacotePremium(string Nome, double Valor, string luz, string som)
        {
            this.Nome = "Pacote Premium";
            this.Valor = 10000;
            this.luz = "SIM";
            this.som = "NÃO";
        }
    }
}