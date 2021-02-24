using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplCslExercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            //A proposta do exercício é pegar a idade de uma pessoa expressa em anos, meses e dias e retorná-la em dias. Os parâmetros eram os seguintes: ano = 365 dias - mês = 30 dias.

            int ano = 0, mes = 0, dia = 0, idadeDias = 0;

            Console.WriteLine("Programa que recebe, respectivamente, sua idade em anos, meses e dias e a converte para dias!");

            Console.WriteLine("\n Digite quantos anos você tem: ");
            ano = int.Parse(Console.ReadLine());
            ano *= 365; //Atribuindo à variável ano o valor dela mesma (o que o usuário digitar) e multiplicando por 365.

            Console.WriteLine("\n Digite quantos meses você tem: ");
            mes = int.Parse(Console.ReadLine());
            mes *= 30; //Atribuindo à variável mes o valor dela mesma (o que o usuário digitar) e multiplicando por 30.

            Console.WriteLine("\n Digite quantos dias você tem: ");
            dia = int.Parse(Console.ReadLine());

            //Somando as variáveis ano, mes e dia para obter a idade em dias.
            idadeDias = ano + mes + dia;

            Console.WriteLine("\n Você tem " + idadeDias.ToString() + " dias de idade!");
            Console.ReadKey();

        }
    }
}
