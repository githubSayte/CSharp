
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_.ParadigmasOO
{
    public class Animal
    {
        protected string Nome;

        // Construtor da classe base
        public Animal(string nome)
        {
            Nome = nome;
        }

        // Método da classe base
        public virtual void FazerSom()
        {
            Console.WriteLine($"{Nome} faz um som.");
        }

        // Método para exibir informações
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Este é um animal chamado {Nome}.");
        }

        // Método para explicar o conceito de herança
        public virtual void ExplicarHeranca()
        {
            Console.WriteLine("Herança é um dos pilares da Programação Orientada a Objetos.");
            Console.WriteLine("Ela permite que uma classe (chamada de subclasse ou classe derivada) herde membros (atributos e métodos) de outra classe (chamada de superclasse ou classe base).");
            Console.WriteLine("Isso promove o reuso de código, facilitando a manutenção e a extensão de funcionalidades.");
            Console.WriteLine("Em C#, podemos sobrescrever métodos da superclasse na subclasse usando a palavra-chave 'override', como no método 'FazerSom'.");
            Console.WriteLine("Por exemplo, classes como 'Cachorro' e 'Gato' herdam de 'Animal', mas cada uma pode ter seu próprio comportamento para métodos herdados.");
            Console.WriteLine("Além disso, através do polimorfismo, objetos de subclasses podem ser tratados como objetos da classe base, permitindo flexibilidade na forma como manipulamos essas classes.");
        }
    }

    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {

        }

        // Sobrescrevendo o método FazerSom da classe base
        public override void FazerSom()
        {
            Console.WriteLine($"{Nome} late.");
        }

        // Sobrescrevendo o método para explicar herança na classe Cachorro
        public override void ExplicarHeranca()
        {
            base.ExplicarHeranca();
            Console.WriteLine("Na classe 'Cachorro', herdamos de 'Animal', e sobrescrevemos o método 'FazerSom' para que o cachorro lata ao invés de emitir um som genérico.");
        }
    }

    public class Gato : Animal
    {
        public Gato(string nome) : base(nome)
        {
        }

        // Sobrescrevendo o método FazerSom da classe base
        public override void FazerSom()
        {
            Console.WriteLine($"{Nome} mia.");
        }

        // Sobrescrevendo o método para explicar herança na classe Gato
        public override void ExplicarHeranca()
        {
            base.ExplicarHeranca();
            Console.WriteLine("Na classe 'Gato', herdamos de 'Animal', e sobrescrevemos o método 'FazerSom' para que o gato mia ao invés de emitir um som genérico.");
        }
    }
}
