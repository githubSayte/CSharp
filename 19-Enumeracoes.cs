using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    // Classe para demonstrar e explicar o conceito de Enumerações (enum)
    public class ExplicacaoEnum
    {
        // Definição de uma Enumeração
        public enum DiasDaSemana
        {
            Domingo,    // Valor padrão: 0
            Segunda,    // Valor: 1
            Terca,      // Valor: 2
            Quarta,     // Valor: 3
            Quinta,     // Valor: 4
            Sexta,      // Valor: 5
            Sabado      // Valor: 6
        }

        // Definição de uma Enumeração com valores específicos
        public enum NiveisDeAcesso
        {
            Administrador = 1,
            Usuario = 2,
            Convidado = 3
        }

        // Método para demonstrar o uso básico de enums
        public void DemonstrarEnum()
        {
            // Atribuindo um valor enum a uma variável
            DiasDaSemana hoje = DiasDaSemana.Quarta;

            // Exibindo o valor do enum e seu valor numérico
            Console.WriteLine($"Hoje é: {hoje} (valor numérico: {(int)hoje})");

            // Comparando enums
            if (hoje == DiasDaSemana.Quarta)
            {
                Console.WriteLine("Hoje é quarta-feira.");
            }

            // Usando um enum com valores específicos
            NiveisDeAcesso acessoUsuario = NiveisDeAcesso.Usuario;
            Console.WriteLine($"Nível de acesso: {acessoUsuario} (valor numérico: {(int)acessoUsuario})");

            // Exibindo todos os valores de um enum
            Console.WriteLine("Dias da semana:");
            foreach (DiasDaSemana dia in Enum.GetValues(typeof(DiasDaSemana)))
            {
                Console.WriteLine($"- {dia} (valor numérico: {(int)dia})");
            }
        }

        // Explicação detalhada sobre enumerações
        public void ExplicacaoDetalhada()
        {
            Console.WriteLine("** O que são Enumerações (enum)? **");
            Console.WriteLine("Enumerações (enums) são tipos de valor definidos pelo usuário que consistem em um conjunto de constantes nomeadas chamadas membros.");
            Console.WriteLine("Elas são usadas para representar um grupo de valores relacionados, tornando o código mais legível e fácil de manter.");
            Console.WriteLine();

            Console.WriteLine("** Exemplo de Enumeração Simples **");
            Console.WriteLine("enum DiasDaSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado }");
            Console.WriteLine("Cada membro do enum é associado a um valor inteiro, começando por padrão em 0, mas você pode atribuir valores específicos.");
            Console.WriteLine();

            Console.WriteLine("** Exemplo de Enumeração com Valores Específicos **");
            Console.WriteLine("enum NiveisDeAcesso { Administrador = 1, Usuario = 2, Convidado = 3 }");
            Console.WriteLine("Neste caso, 'Administrador' é associado ao valor 1, 'Usuario' ao valor 2 e assim por diante.");
            Console.WriteLine();

            Console.WriteLine("** Usos Comuns de Enums **");
            Console.WriteLine("Enums são frequentemente usados em casos como:");
            Console.WriteLine("- Dias da semana");
            Console.WriteLine("- Meses do ano");
            Console.WriteLine("- Estados de um processo (Iniciado, EmAndamento, Concluido)");
            Console.WriteLine("- Níveis de acesso (Administrador, Usuario, Convidado)");
            Console.WriteLine();

            Console.WriteLine("** Operações Comuns com Enums **");
            Console.WriteLine("- Atribuir e comparar valores");
            Console.WriteLine("- Converter para o valor numérico subjacente (int)");
            Console.WriteLine("- Listar todos os valores possíveis de um enum");
        }
    }
}
