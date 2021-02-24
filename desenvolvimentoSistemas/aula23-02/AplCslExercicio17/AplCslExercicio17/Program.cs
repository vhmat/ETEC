using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplCslExercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            //A proposta do exercício era retornar os números de 1 a 10 em ordem decrescente.
            //A estrutura de repetição for abaixo diz que o índice começa em 10 e termina apenas quando for igual a 1.
            for(int i=10; i>=1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
