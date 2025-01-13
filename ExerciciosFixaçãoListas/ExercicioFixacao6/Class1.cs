using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao6
{
    internal class Class1
    {
        public void ProcessaObjetos(params object[] objetos)
        {
            for (int i = 0; i < objetos.Length; i++)
            {
                if (objetos[i] == null)
                {
                    Console.WriteLine("O Objeto é null");
                }
                else
                {
                    Console.WriteLine($"O tipo do objeto é: {objetos[i].GetType()}");
                }
            }
            
        }
    }
}
