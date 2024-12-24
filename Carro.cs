




using Propiedades;

public class Carro
{
    public static double ValorIpva;
    private int ano;
    public int Ano 
    {
        get { return ano; }

        set
        {
            if (value < 2000)
            {
                ano = 2000;
            }
            else if (value > 2022)
            {
                ano = 2022;
            }
            else
            {
                ano = value;
            }
        }
    }
    public string? Marca { get; set; }

    public Cores? Cor { get; set; }


    public Carro(int ano, string? marca, Cores? cor)
    {
        Ano = ano;
        Marca = marca;
        this.Cor = cor;
    }
    //metodo statico ( pertence a classe e não ao objeto sendo criado)
    // só é executado uma vez quando o construtor não tem tipagem
    static Carro()
    {
        ValorIpva = 0.04;
        Console.WriteLine("Valor do IPVA inicializado!");
    }
}