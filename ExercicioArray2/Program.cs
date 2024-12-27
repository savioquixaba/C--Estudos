

Console.WriteLine("Quantos Alunos vão ser cadastrados? ");
int numerodeAlunos = int.Parse(Console.ReadLine());


//Inicializando os Arrays

string[] nomes = new string[numerodeAlunos];
double[] notas = new double[numerodeAlunos];

//inicializando varial para somar as notas

double somaNotas = 0;

for (int i = 0; i < numerodeAlunos; i++)
{
    Console.WriteLine($"Digite o nome do Aluno {i + 1}: ");
    nomes[i] = Console.ReadLine();

    Console.WriteLine($"Digite a nota do Aluno {nomes[i]}: ");
    notas[i] = double.Parse(Console.ReadLine());

    somaNotas += notas[i];
}
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Aluno: {nomes[i]}, Nota: {notas[i]}");
}

//media

double media = somaNotas / nomes.Length ;

Console.WriteLine($"A Média dos alunos é: {media}");

Console.ReadKey();