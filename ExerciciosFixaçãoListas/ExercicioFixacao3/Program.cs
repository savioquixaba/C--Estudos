float[,] notas = new float[2, 5];

float somaNotas1 = 0;
float somaNotas2 = 0;


for (int i = 0; i < notas.GetLength(0); i++)
{
    for (int j = 0; j < notas.GetLength(1); j++)
    {
        Console.WriteLine($"Digite a nota a ser inserida na linha {i} e coluna {j}: ");
        notas[i,j] = float.Parse(Console.ReadLine());

        if(i == 0)
        {
            somaNotas1 += notas[i,j];
            // recebem os dois parametros no "notas[i,j]" por conta da linha e da coluna que o array ta percorrendo
        }
        else if (i == 1) 
        {
            somaNotas2 += notas[i,j];
            // recebem os dois parametros no "notas[i,j]" por conta da linha e da coluna que o array ta percorrendo

        }
    }
}

float mediaGrupo1 = somaNotas1 / 5;
float mediaGrupo2 = somaNotas2 / 5;

Console.WriteLine($"a média do grupo 1 é: {mediaGrupo1}");
Console.WriteLine($"a média do grupo 2 é: {mediaGrupo2}");

Console.ReadKey();"