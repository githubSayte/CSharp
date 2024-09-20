using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class _05_OperadoresAtribuicao
    {

        // Método para demonstrar o operador de atribuição simples (=)
        public static void AtribuicaoSimples()
        {
            int a = 10;
            Console.WriteLine($"Valor de a após atribuição: {a}");
        }

        // Método para demonstrar o operador de atribuição composto com adição (+=)
        public static void AtribuicaoSoma()
        {
            int a = 10;
            a += 5; // Equivalente a a = a + 5
            Console.WriteLine($"Valor de a após a operação a += 5: {a}");
        }

        // Método para demonstrar o operador de atribuição composto com subtração (-=)
        public static void AtribuicaoSubtracao()
        {
            int a = 10;
            a -= 3; // Equivalente a a = a - 3
            Console.WriteLine($"Valor de a após a operação a -= 3: {a}");
        }

        // Método para demonstrar o operador de atribuição composto com multiplicação (*=)
        public static void AtribuicaoMultiplicacao()
        {
            int a = 10;
            a *= 4; // Equivalente a a = a * 4
            Console.WriteLine($"Valor de a após a operação a *= 4: {a}");
        }

        // Método para demonstrar o operador de atribuição composto com divisão (/=)
        public static void AtribuicaoDivisao()
        {
            int a = 20;
            a /= 4; // Equivalente a a = a / 4
            Console.WriteLine($"Valor de a após a operação a /= 4: {a}");
        }

        // Método para demonstrar o operador de atribuição composto com módulo (%=)
        public static void AtribuicaoModulo()
        {
            int a = 20;
            a %= 3; // Equivalente a a = a % 3
            Console.WriteLine($"Valor de a após a operação a %= 3: {a}");
        }

        // Método para demonstrar o operador de atribuição composto com bitwise AND (&=)
        public static void AtribuicaoAnd()
        {
            int a = 12; // Binário: 1100
            a &= 7;    // Binário: 0111
                       // Resultado: 0100 (4 em decimal)
            Console.WriteLine($"Valor de a após a operação a &= 7: {a}");
        }

        // Método para demonstrar o operador de atribuição composto com bitwise OR (|=)
        public static void AtribuicaoOr()
        {
            int a = 12; // Binário: 1100
            a |= 5;    // Binário: 0101
                       // Resultado: 1101 (13 em decimal)
            Console.WriteLine($"Valor de a após a operação a |= 5: {a}");
        }

        // Método para demonstrar o operador de atribuição composto com bitwise XOR (^=)
        public static void AtribuicaoXor()
        {
            int a = 12; // Binário: 1100
            a ^= 6;    // Binário: 0110
                       // Resultado: 1010 (10 em decimal)
            Console.WriteLine($"Valor de a após a operação a ^= 6: {a}");
        }

        // Método para demonstrar o operador de atribuição composto com deslocamento à esquerda (<<=)
        public static void AtribuicaoDeslocamentoEsquerda()
        {
            int a = 4;  // Binário: 0100
            a <<= 2;    // Desloca 2 bits à esquerda: 0001 0000 (16 em decimal)
            Console.WriteLine($"Valor de a após a operação a <<= 2: {a}");
        }

        // Método para demonstrar o operador de atribuição composto com deslocamento à direita (>>=)
        public static void AtribuicaoDeslocamentoDireita()
        {
            int a = 16; // Binário: 0001 0000
            a >>= 2;    // Desloca 2 bits à direita: 0000 0100 (4 em decimal)
            Console.WriteLine($"Valor de a após a operação a >>= 2: {a}");
        }
    }
}
