 string[] frutas = new string[10];


for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"Digite o nome das frutas a serem cadastradas {i + 1}: ");
    frutas[i] = Console.ReadLine();
}

foreach(var f  in frutas)
{
    Console.WriteLine($"\n {f}");
}

Console.WriteLine($"o numero de frutas é: {frutas.Length}");

for(int i = 0;i < frutas.Length ; i++)
{
    if(i == 1)
    {
        Console.WriteLine($"o nome da fruta 2 é : {frutas[i]}");
    }
}
Console.WriteLine($"o nome da ultima fruta é: {frutas[frutas.Length - 1]}");
Console.ReadKey();