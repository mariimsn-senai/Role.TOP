namespace RolêTopMVC.Models
{
    public class Pacote : Produto
    {
        public Pacote()
        {

        }
        
        public Pacote(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}