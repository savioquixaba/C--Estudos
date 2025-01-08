Console.WriteLine("Digite o tamanho do Array: ");
int tamanhoArray = int.Parse(Console.ReadLine());
int[] colecao = new int[tamanhoArray];

Random numeros = new Random();


for (int i = 0; i < colecao.Length; i++)
{
    colecao[i] = numeros.Next(0, tamanhoArray);

}

//foreach (int i in colecao)
//{
//    Console.WriteLine($"{i}");
//}
do
{

    Console.WriteLine("Qual Numero vôce deseja buscar no Array? >> ");
    string entrada = Console.ReadLine();

    if (entrada == "fim")
    {
        break;
    }

    int busca = int.Parse(entrada);

    bool encontrado = false;

    for (int b = 0; b < colecao.Length; b++)
    {
        if (colecao[b] == busca)
        {
            Console.WriteLine($"O numero {colecao[b]} existe e está na lista!");
            encontrado = true;// sai imediatamente do loop e encerra a busca voltando a perguntar se o usuario deseja buscar outro numero
            break;
        }
    }
    if (!encontrado) // Se o número não for encontrado, exibe a mensagem uma unica vez sem repetir
    {
        Console.WriteLine("O número não existe na lista!");
    }

} while(true);



