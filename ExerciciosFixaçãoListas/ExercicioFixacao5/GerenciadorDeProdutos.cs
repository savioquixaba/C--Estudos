using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao5
{
    internal class GerenciadorDeProdutos
    {
        public decimal SomaTotal(List<Produto> produtos)
        {
            decimal soma = 0;
            foreach (Produto produto in produtos)
            {
                soma += produto.Preco;
            }
            return soma;
        }

        public void RelacaoProdutos(List<Produto> produtos)
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}");
            }
        }
        public decimal MediaProdutos(List<Produto> produtos)
        {
            decimal media = 0;
            foreach(Produto produto in produtos)
            {
                media += produto.Preco;
            }
            return media / produtos.Count;
        }

        public void QuantidadeProdutos(List<Produto> produtos)
        {
            Console.WriteLine($"A Quantidade de produtos é: {produtos.Count}");
        }

        public void ProdutosMenor5(List<Produto> produtos)
        {
            foreach(Produto produto in produtos)
            {
                if (produto.Preco < 5)
                {
                    Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}");
                }
            }
        }

        public Produto BuscaPorNome(List<Produto> produtos, string nomeProduto)
        {
            foreach( Produto produto in produtos)
            {
                if (produto.Nome.Equals(nomeProduto))
                {
                    return produto;
                }

            }
            return null;
        }

    }    
}
