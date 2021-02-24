using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplCslExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Criação do primeiro programa em C#
            
            ///Declaração de variáveis 
            double valor, antecessor;

            //Exibindo uma mensagem para o usuário
            Console.Write("Digite um número para saber o número anterior: ");
            //Lendo e armazenando um dado obtido pelo teclado
            valor = double.Parse(Console.ReadLine());

            //Cálculo simples para saber que número vem antes do número digitado pelo usuário
            antecessor = valor - 1;

            //Exibindo o resultado do cálculo acima
            Console.WriteLine("O número antecessor ao " + valor.ToString() + " é " + antecessor.ToString() + "!");
            //Comando utilizado para manter o console aberto depois de exibir o resultado
            Console.ReadKey();
        }
    }
}
