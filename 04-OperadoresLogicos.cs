using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class _04_OperadoresLogicos
    {
        // Método que demonstra o operador E lógico (&&)
        public static bool ELogico(bool a, bool b)
        {
            return a && b;
        }

        // Método que demonstra o operador OU lógico (||)
        public static bool OULogico(bool a, bool b)
        {
            return a || b;
        }
        // Método que demonstra o operador NEGAÇÃO (!)
        public static bool Negacao(bool a)
        {
            return !a;
        }
        // Método que demonstra o operador OU exclusivo (^)
        public static bool OUExclusivo(bool a, bool b)
        {
            return a ^ b;
        }

    }
}
