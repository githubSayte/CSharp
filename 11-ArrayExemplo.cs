using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class ArrayExemplo
    {
        public static void DemonstrarArray()
        {
            // 1. Declaração e Inicialização de Arrays
            int[] numeros = new int[5]; // Array de inteiros com 5 elementos
  
            string[] diasDaSemana =  { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado"  }; // Array de strings

            // 2. Atribuição de Valores aos Elementos do Array
            numeros[0] = 10; // Atribui 10 ao primeiro elemento
            numeros[1] = 20; // Atribui 20 ao segundo elemento
            numeros[2] = 30; // Atribui 30 ao terceiro elemento
            numeros[3] = 40; // Atribui 40 ao quarto elemento
            numeros[4] = 50; // Atribui 50 ao quinto elemento

            // 3. Acesso aos Elementos do Array
            Console.WriteLine("Acessando elementos do array:");
            Console.WriteLine($"Primeiro elemento de numeros: {numeros[0]}");
            Console.WriteLine($"Terceiro elemento de diasDaSemana: {diasDaSemana[2]}");

            // 4. Iteração em Arrays usando 'for'
            Console.WriteLine("\nIteração usando 'for':");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Elemento {i} do array numeros: {numeros[i]}");
            }

            // 5. Iteração em Arrays usando 'foreach'
            Console.WriteLine("\nIteração usando 'foreach':");
            foreach (string dia in diasDaSemana)
            {
                Console.WriteLine($"Dia da semana: {dia}");
            }

            // 6. Arrays Multidimensionais (Matrizes)
            int[,] matriz = new int[3, 2]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            Console.WriteLine("\nAcessando elementos de um array multidimensional:");
            Console.WriteLine($"Elemento [0,0] da matriz: {matriz[0, 0]}");
            Console.WriteLine($"Elemento [1,1] da matriz: {matriz[2, 1]}");

            // 7. Arrays Jagged (Arrays Irregulares)
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };
            //Explicar melhor o conceito acima

            Console.WriteLine("\nAcessando elementos de um array jagged:");
            Console.WriteLine($"Elemento [0][1] do jaggedArray: {jaggedArray[0][1]}");
            Console.WriteLine($"Elemento [2][3] do jaggedArray: {jaggedArray[2][3]}");
        }


    }
}
