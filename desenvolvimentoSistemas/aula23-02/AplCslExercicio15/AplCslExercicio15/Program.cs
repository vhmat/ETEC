using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplCslExercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             Exercício 15 - Ler  a  hora  de  início  e  a  hora  de  fim  de  um  jogo  de  Xadrez (considere apenas  horas  inteiras,  sem  os  minutos)
            e  calcule  a  duração do  jogo  em horas, sabendo-se que o tempo máximo de duração do jogo é de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte. */

            //Declaração das variáveis
            int horaInicio = 0, horaFinal = 0, horasTotais = 0;

            //Requisitando, lendo e armazenando o horário de início do jogo de xadrez
            Console.WriteLine("Digite a hora de início do jogo: ");
            horaInicio = int.Parse(Console.ReadLine());

            //Requisitando, lendo e armazenando o horário de término do jogo de xadrez
            Console.WriteLine("Digite a hora do término do jogo: ");
            horaFinal = int.Parse(Console.ReadLine());
        
            //Se a hora de início do jogo for maior que a hora de término, significa que o jogo passou das 24h/0h
            if(horaInicio > horaFinal)
            {
                horasTotais = horaFinal + (24 - horaInicio); //Esse cálculo pega a hora de início do jogo e soma com as horas restantes para o dia terminar retornando o resultado desejado
            }
            else
            {
                horasTotais = horaFinal - horaInicio; //Esse cálculo pega a hora de término do jogo e subtrai a hora de início retornando o resultado desejado
            }

            //Retornando a duração total do jogo de xadrez para o usuário.
            Console.WriteLine("O jogo durou " + horasTotais.ToString() + " horas.");

            Console.ReadKey();
        }
    }
}
