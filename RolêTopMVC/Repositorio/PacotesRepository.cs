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

        }
    }