using System.Collections;
using ExercicioFixacao4;

ArrayList Pessoas = new ArrayList();
int count = 0;
do
{

        Console.WriteLine("Digite o Nome da Pessoa ou fim: ");
        string Nome = Console.ReadLine();
        if (Nome == "fim")
        {
            break;
        }

    Console.WriteLine("Digite a Idade da Pessoa: ");
        int Idade = int.Parse(Console.ReadLine());

        Pessoa novaPessoa = new Pessoa(Nome, Idade);

        Pessoas.Add(novaPessoa);

        count++;
        if (count == 3)
        {
            foreach (Pessoa pessoa in Pessoas)
            {
                pessoa.exibirDados();
            }
            

        }

    if(count != 3 && count != 5)
    {
        Console.WriteLine("Voce deseja ver a lista de pessoas? digite s/n: ");
        string entrada = Console.ReadLine();
        if (entrada == "s")
        {
            foreach (Pessoa pessoa in Pessoas)
            {
                pessoa.exibirDados();
            }
        }
    }
    
    if (count == 5)
    {
        Console.WriteLine("voce deseja excluir a ultima pessoa da lista? digite s/n: ");
        string entradaDelete = Console.ReadLine();
        if (entradaDelete == "s" )
        {
            Pessoas.RemoveAt(Pessoas.Count - 1);
            Console.WriteLine("Ultima pessoa removida com Sucesso");
            foreach (Pessoa pessoa in Pessoas)
            {
                pessoa.exibirDados();
            }
        }
    }
    

}while(true);