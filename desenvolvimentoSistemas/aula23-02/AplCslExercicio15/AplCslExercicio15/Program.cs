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

            int horaInicio = 0, horaFinal = 0, horasTotais = 0;

            Console.WriteLine("Digite a hora de início do jogo: ");
            horaInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora do término do jogo: ");
            horaFinal = int.Parse(Console.ReadLine());
        
            if(horaInicio > horaFinal)
            {
                horasTotais = horaFinal + (24 - horaInicio);
            }
            else
            {
                horasTotais = horaFinal - horaInicio;
            }

            Console.WriteLine("O jogo durou " + horasTotais.ToString() + " horas.");

            Console.ReadKey();
        }
    }
}
