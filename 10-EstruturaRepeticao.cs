using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class EstruturaRepeticao
    {
        public static void DemonstrarRepeticoes()
        {
            // 1. Estrutura de Repetição 'for'
            Console.WriteLine("Estrutura for:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteração {i}");
            }

            // 2. Estrutura de Repetição 'while'
            Console.WriteLine("\nEstrutura while:");
            int contadorWhile = 0;
            while (contadorWhile < 5)
            {
                Console.WriteLine($"Iteração {contadorWhile}");
                contadorWhile++;
            }

            // 3. Estrutura de Repetição 'do-while'
            Console.WriteLine("\nEstrutura do-while:");
            int contadorDoWhile = 0;
            do
            {
                Console.WriteLine($"Iteração {contadorDoWhile}");
                contadorDoWhile++;
            } while (contadorDoWhile < 5);

            // 4. Estrutura de Repetição 'foreach'
            Console.WriteLine("\nEstrutura foreach:");
            string[] frutas = { "Maçã", "Banana", "Laranja", "Uva" };
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }

    }
}
