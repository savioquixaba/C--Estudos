


// o list está recebendo o Tipo aluno, nesse caso a lista pode receber varios objetos do tipo Aluno.
List<Aluno> alunos = new();

//metodo AddRange() recebe varios objetos da classe aluno e joga tudo de uma vez dentro da lista
alunos.AddRange(new List<Aluno>
{
    new Aluno("Maria", 8.75),
    new Aluno("Manoel", 6.95),
    new Aluno("Amanda", 7.25),
    new Aluno("Carlos", 6.55),
    new Aluno("Jaime", 8.50),
    new Aluno("Debora", 5.95),
    new Aluno("Alicia", 9.25),
    new Aluno("Sandra", 5.55),
    new Aluno("Marta", 7.85),
    new Aluno("Sueli", 9.15)
});

//inicializando dois novos alunos
Aluno aluno1 = new Aluno("Bia", 7.75);
Aluno aluno2 = new Aluno("Mario", 8.95);

//colocando os novos alunos na lista, sem esse metodo mesmo inicializando e alocando memoria para eles, não apareceriam na lista.
alunos.Add(aluno1);
alunos.Add(aluno2);


//Aluno.ExibirAlunos(alunos);
Aluno.MediaAlunos(alunos);
Aluno.Contagem(alunos);
//Aluno.Search(alunos); 
//Aluno.Ordenar(alunos);
Aluno.ExibirAlunos(alunos);
Aluno.MaiorNota(alunos);


public class Aluno
{
    private string nome;
    private double nota;

    public Aluno(string nome, double nota) {
        this.nome = nome;
        this.nota = nota;
    }


    public string Nome
    {
        get { return nome; }

        set { nome = value; }
    }

    public double Nota
    {
        get { return nota; }
        set { nota = value; }
    }

    public static void ExibirAlunos(List<Aluno> alunos)
    {
        for (int i = 0; i < alunos.Count; i++)
        {
            Console.WriteLine($"Nome:{alunos[i].Nome}, Nota:{alunos[i].Nota}");
        }
    }
    public static void MediaAlunos(List<Aluno>alunos)
    {
        //variavel local para receber o valor das notas e somar para dar a média no final
        double somaNotas = 0;

        for (int i = 0; i < alunos.Count; i++) { 
            somaNotas += alunos[i].Nota;
            //equivale a somaNotas = somaNotas + alunos[i].Nota;
        }
        double media = somaNotas / alunos.Count;
        Console.WriteLine($"A Média das notas é: {media}");
    }

    public static void Contagem(List<Aluno> alunos) {
        Console.WriteLine($"O numero total de alunos é: {alunos.Count}");
    }

    public static void Search(List<Aluno> alunos)
    {
        Console.WriteLine("Digite o nome do Aluno a ser buscado: ");
        string nomeAluno = Console.ReadLine();
        //metodo find sempre usa funções lambdas ou na maioria dos casos;
        Aluno aluno = alunos.Find(a => a.Nome == nomeAluno);
        if (aluno != null)
        {
            Console.WriteLine($"Nome:{aluno.nome}, Nota: {aluno.Nota}");
        }
        else
        {
            Console.WriteLine("aluno não encontrado!");
        }
    
    }

    public static void Ordenar(List<Aluno> alunos)
    {
        //aqui ele está recebendo dois parametros e comparando o paramentro a com o B e ordenamento no metodo sort(crescente)
        alunos.Sort((a, b) => a.Nome.CompareTo(b.Nome));  
    }

    public static void MaiorNota(List<Aluno> alunos)
    {
        foreach (var Aluno in alunos)
        {
            if(Aluno.Nota > 8)
            {
                Console.WriteLine($"Aluno com nota alta : {Aluno.Nome}");
            }
        }
    }
}
