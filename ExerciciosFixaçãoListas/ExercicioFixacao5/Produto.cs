using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao5
{
    internal class Produto
    {
        string nome;
        decimal preco;

        public Produto(string nome, decimal preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public string Nome { 
            
            
            
           get { return nome; } 
           set { nome = value; }
        
        
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

    }
}
