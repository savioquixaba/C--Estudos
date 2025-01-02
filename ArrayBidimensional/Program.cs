
//inicializando o array bidimensional com 2 linhas e 5 tabelas.
Console.WriteLine("criando array...");
string[,] alunos = new string[2, 5];

//o primeiro for vai rodar na dimensão 0 que corresponde as linhas do array
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        //o segundo vai fazer a mesma coisa so que nas tabelas

        Console.WriteLine($"Digite o nome do aluno a ser inserido na linha [{i} na tabela {j}]: ");
        alunos[i, j] = Console.ReadLine();

        // Exibe o estado atual do array
        Console.WriteLine("\nEstado atual do array:");
        for (int linha = 0; linha < alunos.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < alunos.GetLength(1); coluna++)
            {
                Console.Write(string.IsNullOrEmpty(alunos[linha, coluna]) ? "- " : $"{alunos[linha, coluna]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(); // 
    }

}

Console.WriteLine("Array completo com Indices ");
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Nome na posição [{i}, {j}]: {alunos[i, j]}");
    }
}
Console.ReadKey();