using System.Collections.Generic;
using System.IO;
using RolêTopMVC.Models;

namespace RolêTopMVC.Repositorio
{
    public class PacotesRepository
    {
                private const string PATH = "Database/Pacote.csv";

        public double ObterPrecoDe(string nomePacote)
        {
            var lista = ObterTodos();
            var preco = 0.0;

            foreach (var item in lista)
            {

                if(item.Nome.Equals(nomePacote))
                {
                    //preco = item.Preco;
                    break;
                }
            }
                return preco;
        }

        public List<Pacote> ObterTodos()
        {
            List<Pacote> pacote = new List<Pacote>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var linha in linhas)
            {
                Pacote P = new Pacote();
                string[] dados = linha.Split(";");
                P.Nome = dados[0];
                P.valor = double.Parse(dados[1]);
                pacote.Add(P);
                
            }

            return pacote;

        }
    }
}