using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public static class OperadoresAritmeticos
    {     /** 
               Soma = +
               Subtração = -
               Divisão = /
               Multiplicação = *
           */
        public static void Soma() 
        { 
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A soma e:{n1 + n2}");
        }
        public static void Subtracao()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A subtração e:{n1 - n2}");
        }
        public static void Divisao()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A divisão e:{n1 / n2}");
        }
        public static void Multiplicacao()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A multiplicação e:{n1 * n2}");
        }
        public static void Resto()
        {
            int n1 = 11, n2 = 2;
            Console.WriteLine($"O resto e:{n1 % n2}");
        }
        public static void Incremento()
        {
            int n1 = 1;
            Console.WriteLine($"O incremento e:{n1++}");
        }
        public static void Decremento()
        {
            int n1 = 1;
            Console.WriteLine($"O descremento e:{n1--}");
        }
    }
}
