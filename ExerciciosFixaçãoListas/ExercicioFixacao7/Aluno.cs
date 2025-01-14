using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao7
{
    internal class Aluno
    {
        

        private string[] nomes = new string[10];

        public string this[int index]
        {
            get { return nomes[index]; }
            set { nomes[index] = value; }
        }

        public void ExibirNomes()
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (!string.IsNullOrEmpty(nomes[i]))
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}