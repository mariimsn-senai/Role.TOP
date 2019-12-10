using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using RolêTopMVC.Models;

namespace RolêTopMVC.Repositorio
{
    public class ProdutoRepository : RepositoryBaase
    {
        private const string PATH = "DataBase/Pedidos.csv";

        public ProdutoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Produto Produto)
        {
            var qtdeEvento = File.ReadAllLines(PATH).Length;
            Produto.Id = (ulong) ++ qtdeEvento;
            var linha = new string[]{PrepararEventoCSV(Produto)};
            File.AppendAllLines(PATH, linha);
            return true;
        }



        public List<Produto> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Produto> eventos = new List<Produto>();

            foreach (var item in linhas)
            {
                Produto pedido = new Produto();

                    pedido.Id = ulong.Parse(ExtrairValorDoCampo("Id", item));
                    pedido.Nome = ExtrairValorDoCampo("Nome", item);
                    pedido.data= ExtrairValorDoCampo("data", item);
                    pedido.horario = ExtrairValorDoCampo("horario", item);
                    pedido.parcelas = ExtrairValorDoCampo("parcelas", item);

                eventos.Add(pedido);
            }
            return null;
        }
        
        public Produto ObterPor(ulong id)
        {
            var pedidoTotais = ObterTodos();
            foreach (var pedido in pedidoTotais)
            {
                if(id.Equals(pedido.Id))
                {
                    return pedido;
                }
            }
            return null;
        }
        
        private string PrepararEventoCSV(Produto produto)
        {
            return $"Id={produto.Id};Nome={produto.Nome};Valor={produto.Valor};data={produto.data};horario={produto.horario};parcelas={produto.parcelas}";
        }
    }
}