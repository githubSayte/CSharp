using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class Conversao
    {
        public static void DemonstrarConversoes()
        {
            // 1. Conversão Implícita (Implicit Conversion)
            int numInt = 100;
            long numLong = numInt; // Conversão implícita de int para long
            Console.WriteLine($"Conversão implícita de int para long: {numLong}");

            // 2. Conversão Explícita (Casting)
            double numDouble = 1234.56;
            int numCast = (int)numDouble; // Conversão explícita de double para int (perda de dados decimais)
            Console.WriteLine($"Conversão explícita de double para int (cast): {numCast}");

            // 3. Conversão com Convert
            string numeroString = "456";
            int numConvert = Convert.ToInt32(numeroString); // Conversão de string para int usando Convert
            Console.WriteLine($"Conversão de string para int usando Convert: {numConvert}");

            // 4. Conversão com Parse
            string numeroString2 = "789";
            int numParse = int.Parse(numeroString2); // Conversão de string para int usando Parse
            Console.WriteLine($"Conversão de string para int usando Parse: {numParse}");

            // 5. Uso de TryParse para conversão segura
            string numeroInvalido = "abc";
            bool conversaoSucesso = int.TryParse(numeroInvalido, out int numTryParse);
            Console.WriteLine($"Conversão com TryParse (sucesso): {conversaoSucesso}, valor: {numTryParse}");

            // 6. Conversão de tipos incompatíveis
            object obj = 1234; // Boxing
            int numUnboxed = (int)obj; // Unboxing (conversão explícita)
            Console.WriteLine($"Unboxing de object para int: {numUnboxed}");

            // 7. Conversão de tipos numéricos para string
            int numero = 42;
            string numString = numero.ToString(); // Conversão de int para string
            Console.WriteLine($"Conversão de int para string: {numString}");
        }
    }
}
