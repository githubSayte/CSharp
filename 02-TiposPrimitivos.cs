using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public static class TipoPrimitivo
    {        
        public static void ImprimirTipos()
        {
            
            sbyte SByte = -128; // Valores variam de -128 a 127
            Console.WriteLine($"sbyte: {SByte}");
          
            byte variavelByte = 255; // Valores variam de 0 a 255
            Console.WriteLine($"byte: {variavelByte}");
            
            short variavelShort = -32768; // Valores variam de -32768 a 32767
            Console.WriteLine($"short: {variavelShort}");
            
            ushort variavelUShort = 65535; // Valores variam de 0 a 65535
            Console.WriteLine($"ushort: {variavelUShort}");
            
            int variavelInt = -2147483648; // Valores variam de -2147483648 a 2147483647
            Console.WriteLine($"int: {variavelInt}");
            
            uint variavelUInt = 4294967295; // Valores variam de 0 a 4294967295
            Console.WriteLine($"uint: {variavelUInt}");
          
            long variavelLong = -9223372036854775808; // Valores variam de -9223372036854775808 a 9223372036854775807
            Console.WriteLine($"long: {variavelLong}");
                       
            ulong variavelULong = 18446744073709551615; // Valores variam de 0 a 18446744073709551615
            Console.WriteLine($"ulong: {variavelULong}");
            
            float variavelFloat = 3.14f; // Valores variam de ±1.5 x 10^−45 a ±3.4 x 10^38, precisão de 7 dígitos
            Console.WriteLine($"float: {variavelFloat}");
           
            double variavelDouble = 3.141592653589793; // Valores variam de ±5.0 × 10^−324 a ±1.7 × 10^308, precisão de 15-16 dígitos
            Console.WriteLine($"double: {variavelDouble}");
            
            decimal variavelDecimal = 79228162514264337593543950335M; // Valores variam de ±1.0 x 10^-28 a ±7.9 x 10^28, precisão de 28-29 dígitos
            Console.WriteLine($"decimal: {variavelDecimal}");
           
            char variavelChar = 'A'; // Valores variam de '\u0000' a '\uffff'
            Console.WriteLine($"char: {variavelChar}");
           
            bool variavelBool = true; // Valores são true ou false
            Console.WriteLine($"bool: {variavelBool}");
           
            object variavelObject = null; // Pode conter qualquer tipo de valor
            Console.WriteLine($"object: {variavelObject}");
           
            string variavelString = "Olá, Mundo!"; // Uma cadeia de caracteres
            Console.WriteLine($"string: {variavelString}");
        }
    }
}
