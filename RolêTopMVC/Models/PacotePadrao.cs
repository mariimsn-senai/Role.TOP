namespace RolêTopMVC.Models
{
    public class PacotePadrao : Produto
    {
        public PacotePadrao()
        {

        }

        public PacotePadrao(string Nome, double Valor, string luz, string som)
        {
            this.Nome = "Pacote Simples";
            this.Valor = 10000;
            this.luz = luz;
            this.som = som;
        }
    }
}