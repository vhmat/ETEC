using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplCslExercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            //O exercício proposto era retornar os números de 1 a 10 em ordem crescente.
            //Com a estrutura de repetição abaixo, o índice começa em 1 e termina somente quando for igual a 10.
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
            }
                Console.ReadKey(); 
        }
    }
}
