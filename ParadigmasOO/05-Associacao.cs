using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_.ParadigmasOO
{
    // Classe Departamento representa um departamento de uma empresa
    public class Departamento
    {
        public string Nome { get; set; }

        public Departamento(string nome)
        {
            Nome = nome;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Departamento: {Nome}");
        }
    }

    // Classe Funcionario representa um funcionário que pode estar associado a um departamento
    public class Funcionario
    {
        public string Nome { get; set; }
        public Departamento Departamento { get; set; }

        public Funcionario(string nome, Departamento departamento = null)
        {
            Nome = nome;
            Departamento = departamento; // Associação opcional
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Funcionário: {Nome}");
            if (Departamento != null)
            {
                Departamento.ExibirInformacoes(); // Mostra informações do departamento, se associado
            }
            else
            {
                Console.WriteLine("Não está associado a nenhum departamento.");
            }
        }

        // Método que explica o conceito de Associação
        public void ExplicarAssociacao()
        {
            Console.WriteLine("Associação é um relacionamento entre duas classes onde uma classe usa ou se refere a outra.");
            Console.WriteLine("Diferentemente da agregação, a associação pode ser mais flexível, e o ciclo de vida das classes associadas não está estritamente ligado.");
            Console.WriteLine("Uma classe pode se associar a outra sem que haja uma dependência forte entre elas.");
            Console.WriteLine("No exemplo, a classe 'Funcionario' pode estar associada a um 'Departamento', mas isso não impede que o 'Funcionario' exista independentemente do 'Departamento'.");
            Console.WriteLine("A associação pode ser unidirecional (um lado tem conhecimento do outro) ou bidirecional (ambos lados têm conhecimento um do outro).");
        }
    }

}