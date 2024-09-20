using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_.ParadigmasOO
{
    // Classe Endereco representa um endereço genérico
    public class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }

        public Endereco(string rua, string cidade)
        {
            Rua = rua;
            Cidade = cidade;
        }

        public void ExibirEndereco()
        {
            Console.WriteLine($"Rua: {Rua}, Cidade: {Cidade}");
        }
    }

    // Classe Pessoa representa uma pessoa que possui um endereço (Agregação)
    public class PessoaAgrecacao
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }

        public PessoaAgrecacao(string nome, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco; // Aqui ocorre a agregação
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Endereco.ExibirEndereco(); // A pessoa usa o objeto Endereco
        }

        // Método que explica o conceito de Agregação
        public void ExplicarAgregacao()
        {
            Console.WriteLine("Agregação é um relacionamento entre classes onde uma classe contém outra classe como parte de sua composição.");
            Console.WriteLine("No entanto, a classe contida (o 'todo' e a 'parte') pode existir independentemente. Se o objeto que contém for destruído, o objeto contido pode continuar existindo.");
            Console.WriteLine("Por exemplo, uma 'Pessoa' pode ter um 'Endereco', mas o 'Endereco' pode existir sem a 'Pessoa'.");
            Console.WriteLine("Ou seja, o ciclo de vida do objeto contido não depende do ciclo de vida do objeto que o contém.");
        }
    }

}
