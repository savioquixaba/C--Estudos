
using ExercicioFixacao5;


List<Produto> produtos = new List<Produto>()
{
    new Produto("Clips", 3.95m),
    new Produto("Caneta", 5.99m),
    new Produto("Lápis", 4.15m),
    new Produto("Estojo", 6.99m),
    new Produto("Caderno", 7.55m)
};
GerenciadorDeProdutos gerenciador = new GerenciadorDeProdutos();

decimal soma = gerenciador.SomaTotal(produtos);

gerenciador.RelacaoProdutos(produtos);

decimal media = gerenciador.MediaProdutos(produtos);
Console.WriteLine($"a Media dos preços dos produtos é: {media}");

gerenciador.QuantidadeProdutos(produtos);

Produto produto1 = new Produto("Mochila", 22.44m);
produtos.Add(produto1);

gerenciador.RelacaoProdutos(produtos);
Console.WriteLine("\nSEPARANDO LISTA\n");
produtos.Sort((produto1, produto2)=> produto1.Nome.CompareTo(produto2.Nome));
gerenciador.RelacaoProdutos(produtos);

Console.WriteLine("\noutra lista \n");

gerenciador.ProdutosMenor5(produtos);

Produto produtoEncontrado = gerenciador.BuscaPorNome(produtos, "Caneta");
if(produtoEncontrado != null)
{
    Console.WriteLine("\nProduto Encontrado\n");
}
else
{
    Console.WriteLine("Produto não encontrado");
}