using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplCslExercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            //A proposta do exercício era criar um programa onde o usuário digitasse 10 números e o sistema calculava a soma de todos os números inferiores a 40.

            //Declaração das variáveis
            int i = 0, numero = 0, soma = 0, contador = 0;

            //Estrutura de repetição for para fazer a leitura, armazenamento e cálculo dos dados digitados pelo usuário.
            for(i=1; i<=10; i++)
            {
                //Lendo e armazenando os dados inseridos pelo usuário.
                Console.WriteLine("Digite o " + i.ToString() + "º número: ");
                numero = int.Parse(Console.ReadLine());

                //Estrutura de decisão onde verifica se o número inserido pelo usuário foi inferior a 40.
                if (numero < 40)
                {
                    soma += numero; //Realizando a soma dos números inferiores a 40 a cada execução do for e do if.
                    contador++; //Contador realizando a soma de quantas vezes o usuário digitou um número inferior a 40.
                }
            }

            //Estrutura de decisão para definir a mensagem a ser exibida para o usuário de acordo com a quantidade de números inferiores a 40 inseridas pelo mesmo.
            if (contador == 0) //Exibe uma mensagem de inserções inexistentes.
            {
                Console.WriteLine("Você não digitou nenhum número inferior a 40!");
            }
            else if (contador == 1) //Exibe uma mensagem no singular. 
            {
                Console.WriteLine("Você digitou " + contador.ToString() + " número inferior a 40 e esse número foi o " + soma.ToString() + ".");
            }
            else //Exibe uma mensagem no plura.
            {
                Console.WriteLine("Você digitou " + contador.ToString() + " números inferiores a 40 e a soma de todos é igual a " + soma.ToString() + ".");
            }
            Console.ReadKey();
        }
    }
}
