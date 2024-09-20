using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class OperadoresComparacao
    {
        public static void DemonstrarOperadores()
        {
            int a = 10;
            int b = 20;

            // Igual a (==)
            bool igual = (a == b);
            Console.WriteLine($"a == b: {igual}"); // False, porque 10 não é igual a 20

            // Diferente de (!=)
            bool diferente = (a != b);
            Console.WriteLine($"a != b: {diferente}"); // True, porque 10 é diferente de 20

            // Maior que (>)
            bool maior = (a > b);
            Console.WriteLine($"a > b: {maior}"); // False, porque 10 não é maior que 20

            // Menor que (<)
            bool menor = (a < b);
            Console.WriteLine($"a < b: {menor}"); // True, porque 10 é menor que 20

            // Maior ou igual a (>=)
            bool maiorOuIgual = (a >= b);
            Console.WriteLine($"a >= b: {maiorOuIgual}"); // False, porque 10 não é maior ou igual a 20

            // Menor ou igual a (<=)
            bool menorOuIgual = (a <= b);
            Console.WriteLine($"a <= b: {menorOuIgual}"); // True, porque 10 é menor ou igual a 20
        }
    }
}
