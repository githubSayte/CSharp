using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class Metodos
    {
        // Definição de um método simples que retorna uma saudação
        public string Saudacao(string nome)
        {
            return $"Olá, {nome}!";
        }

        // Exemplo de passagem de parâmetros por valor
        public int DobrarValor(int numero)
        {
            numero *= 2;
            return numero;
        }

        // Exemplo de passagem de parâmetros por referência usando 'ref'
        public void DobrarValorRef(ref int numero)
        {
           numero = numero * 2;
        }

        // Exemplo de passagem de parâmetros por referência usando 'out'
        public void DividirPorDois(int numero, out int resultado)
        {
            resultado = numero / 2;
        }

        // Exemplo de método sobrecarregado: mesmo nome, diferentes assinaturas
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public double Somar(double a, double b)
        {
            return a + b;
        }

        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        // Método para demonstrar todos os conceitos em uso
        public void DemonstrarMetodos()
        {
            // Usando o método Saudacao
            string saudacao = Saudacao("Maria");
            Console.WriteLine(saudacao);

            // Passagem de parâmetro por valor
            int valor = 5;
            Console.WriteLine($"Valor original: {valor}");
            int valorDobrado = DobrarValor(valor);
            Console.WriteLine($"Valor dobrado (por valor): {valorDobrado}");
            Console.WriteLine($"Valor após método (por valor): {valor}");

            // Passagem de parâmetro por referência com 'ref'
            int valorRef = 5;
            Console.WriteLine($"Valor original: {valorRef}");
            DobrarValorRef(ref valorRef);
            Console.WriteLine($"Valor dobrado (por ref): {valorRef}");

            // Passagem de parâmetro por referência com 'out'
            int valorOut = 10;
            DividirPorDois(valorOut, out int resultadoOut);
            Console.WriteLine($"Valor original: {valorOut}");
            Console.WriteLine($"Resultado da divisão (por out): {resultadoOut}");

            // Usando métodos sobrecarregados
            int soma1 = Somar(2, 3);
            double soma2 = Somar(2.5, 3.5);
            int soma3 = Somar(1, 2, 3);

            Console.WriteLine($"Soma de 2 e 3 (int): {soma1}");
            Console.WriteLine($"Soma de 2.5 e 3.5 (double): {soma2}");
            Console.WriteLine($"Soma de 1, 2 e 3 (int): {soma3}");
        }
    }
}
