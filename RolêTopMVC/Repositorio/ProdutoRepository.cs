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
            try{
            var qtdeEvento = File.ReadAllLines(PATH).Length;
            Produto.Id = (ulong) ++ qtdeEvento;

            var linha = new string[]{PrepararEventoCSV(Produto)};
            File.AppendAllLines(PATH, linha);

            return true;
            }catch(IOException e){
                System.Console.WriteLine(e.StackTrace);
                return false;
            }
        }



        public List<Produto> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Produto> eventos = new List<Produto>();

            foreach (var item in linhas)
            {
                Produto pedido = new Produto();

                    pedido.Id = ulong.Parse(ExtrairValorDoCampo("Id", item));
                    pedido.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", item));
                    pedido.Nome = ExtrairValorDoCampo("Nome", item);
                    pedido.data= ExtrairValorDoCampo("data", item);
                    pedido.horario = ExtrairValorDoCampo("horario", item);
                    pedido.parcelas = ExtrairValorDoCampo("parcelas", item);

                eventos.Add(pedido);
            }
            return null;
        }

        public bool Atualizar(Produto pedido)
        {
            var pedidosTotais = File.ReadAllLines(PATH);
            var pedidoCSV = PrepararEventoCSV(pedido);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id" , pedidosTotais[i]));
                if(pedido.Id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }
            
            if(resultado)
            {
                pedidosTotais[linhaPedido] = pedidoCSV;
                File.WriteAllLines(PATH, pedidosTotais);
            }

            return resultado;

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
            return $"Id={produto.Id};status_pedido={produto.Status};Nome={produto.Nome};Valor={produto.Valor};data={produto.data};horario={produto.horario};parcelas={produto.parcelas}";
        }
    }
}