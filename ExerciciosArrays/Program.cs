string[] frutas = new string[10] {"Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"};


//for (int i = 0; i < frutas.Length; i++)
//{
//    Console.WriteLine($"Digite o nome das frutas a serem cadastradas {i + 1}: ");
//    frutas[i] = Console.ReadLine();
//}

frutas[2] = "caqui";
frutas[9] = "Kiwi";

Array.Sort(frutas);
Array.Reverse(frutas);

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
