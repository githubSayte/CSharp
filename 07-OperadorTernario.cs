using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class _07_OperadorTernario
    {
        public static void DemonstrarTernario()
        {
            int a = 10;
            int b = 20;

            // Usando o operador ternário para encontrar o maior valor entre a e b
            int maior = (a > b) ? a : b;
           /* 
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else 
            {
                Console.WriteLine(b);
            }
           */
            Console.WriteLine($"O maior valor entre {a} e {b} é: {maior}");

            // Outro exemplo: Verificar se um número é par ou ímpar
            int numero = 15;
            string resultado = (numero % 2 == 0) ? "par" : "ímpar";
           /*
                if (numero % 2 == 0)
                {
                    Console.WriteLine("par");
                }
                else 
                {
                    Console.WriteLine("impar");
                }
           */
            Console.WriteLine($"O número {numero} é {resultado}");

            // Exemplo com uma string: Verificar se um nome está vazio
            string nome = "";
            string mensagem = (!string.IsNullOrEmpty(nome)) ? "Nome válido" : "Nome inválido";

            Console.WriteLine(mensagem);
            /*
                if (!string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Nome válido");
                }
                else
                {
                    Console.WriteLine("Nome inválido");
                }
            */
        }

    }
}
