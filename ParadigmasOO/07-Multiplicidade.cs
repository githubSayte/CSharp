using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_.ParadigmasOO
{
    // Classe Projeto representa um projeto que pode ter vários funcionários associados
    public class Projeto
    {
        public string Nome { get; set; }
        public List<FuncionarioMulti> Funcionarios { get; set; } // Um Projeto pode ter vários Funcionários

        public Projeto(string nome)
        {
            Nome = nome;
            Funcionarios = new List<FuncionarioMulti>(); // Inicializa a lista de Funcionários
        }

        public void AdicionarFuncionario(FuncionarioMulti funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Projeto: {Nome}");
            Console.WriteLine("Funcionários associados:");
            foreach (var funcionario in Funcionarios)
            {
                Console.WriteLine($"- {funcionario.Nome}");
            }
        }

        // Método que explica o conceito de Multiplicidade
        public void ExplicarMultiplicidade()
        {
            Console.WriteLine("Multiplicidade define o número de instâncias de uma classe que podem estar associadas a uma instância de outra classe.");
            Console.WriteLine("No exemplo, um 'Projeto' pode estar associado a múltiplos 'Funcionários'.");
            Console.WriteLine("Essa associação é representada por uma lista de 'Funcionários' dentro da classe 'Projeto', indicando que um projeto pode ter zero ou mais funcionários.");
            Console.WriteLine("A multiplicidade pode ser descrita como '1..1' (uma instância) ou '0..*' (zero ou mais instâncias), dependendo do contexto da associação.");
        }
    }

    // Classe Funcionario representa um funcionário que pode estar associado a projetos
    public class FuncionarioMulti
    {
        public string Nome { get; set; }

        public FuncionarioMulti(string nome)
        {
            Nome = nome;
        }
    }

}
