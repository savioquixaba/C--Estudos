using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao4
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        
        public Pessoa(string nome, int idade) 
        {
            this.nome = nome;
            this.idade = idade;
        }
        
        
        public string Nome
        {
            get{ return nome; }

            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }

            set { idade = value; }
        }
        
        public void exibirDados()
        {
            Console.WriteLine($"Nome:{nome}, Idade:{idade}");
        }
        
    
    
    
    }
}
