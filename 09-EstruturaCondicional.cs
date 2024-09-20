using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class _9_EstruturaCondicional
    {
        public static void DemonstrarCondicionais()
        {
            int numero = 25;

            // Exemplo de if-else if-else
            if (numero < 10)
            {
                Console.WriteLine("O número é menor que 10");
            }
            else if (numero < 20)
            {
                Console.WriteLine("O número é menor que 20");
            }
            else
            {
                Console.WriteLine("O número é 20 ou maior");
            }

            // Exemplo de switch
            string diaSemana = "Segunda-feira";

            switch (diaSemana)
            {
                case "Segunda-feira":
                    Console.WriteLine("Hoje é segunda-feira");
                    break;
                case "Terça-feira":
                    Console.WriteLine("Hoje é terça-feira");
                    break;
                case "Quarta-feira":
                    Console.WriteLine("Hoje é quarta-feira");
                    break;
                default:
                    Console.WriteLine("Não é um dia da semana reconhecido");
                    break;
            }
        }
    }
}
