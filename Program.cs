using Propiedades;

Console.WriteLine("Menu de Cores: ");
foreach(var cor in Enum.GetValues(typeof(Cores)))
{
    Console.WriteLine($"{cor}: {(int) cor}");
}

Console.WriteLine("selecione o numero correspondente a cor do Carro: ");
int corSelecionada = int.Parse(Console.ReadLine());

Carro c1 = new(2023, "lambo",(Cores) corSelecionada);
Console.WriteLine($"\nCarro criado: {c1.Marca}, Ano: {c1.Ano}, Cor: {c1.Cor}, {Carro.ValorIpva * 100}%");

Console.WriteLine($"IPVA para o carro: {Carro.ValorIpva * 100}%");


double valorCarro = 500000; // Exemplo: valor estimado do carro
double ipvaCalculado = Carro.ValorIpva * valorCarro;
Console.WriteLine($"IPVA ({Carro.ValorIpva * 100}% do valor do carro): R$ {ipvaCalculado:N2}");





Console.ReadKey();
