using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public static class EntradaSaidaDadoss
    {
        public static void LerArmazenar() 
        {
             
            Console.Write("Digite o seu nome:");
            string? nome = Console.ReadLine();

            Console.Write($"O nome e: {nome}");
        
        }
    }
}
