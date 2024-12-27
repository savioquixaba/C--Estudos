string[] nomes = new string[5];

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Digite o nome do Aluno {i + 1} : ");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine("\n pulando a linha");
foreach (var nome in nomes)
{
    Console.WriteLine( $"\n{nome}");
}

Console.ReadKey();