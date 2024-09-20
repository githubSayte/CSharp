using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_.ParadigmasOO
{
    // Classe Motor representa um motor de um carro
    public class Motor
    {
        public string Modelo { get; set; }

        public Motor(string modelo)
        {
            Modelo = modelo;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Motor modelo: {Modelo}");
        }
    }

    // Classe Carro representa um carro que possui um motor (Composição)
    public class Carro
    {
        public string Marca { get; set; }
        public Motor Motor { get; private set; } // Composição: O Carro tem um Motor

        public Carro(string marca, string modeloMotor)
        {
            Marca = marca;
            Motor = new Motor(modeloMotor); // O Carro cria um Motor internamente
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro marca: {Marca}");
            Motor.ExibirInformacoes(); // O Carro usa o Motor
        }

        // Método que explica o conceito de Composição
        public void ExplicarComposicao()
        {
            Console.WriteLine("Composição é um tipo de relacionamento entre classes onde uma classe é parte de outra classe.");
            Console.WriteLine("A classe que contém (o 'todo') cria e gerencia a instância da classe contida (a 'parte').");
            Console.WriteLine("A parte não pode existir sem o todo, e o ciclo de vida da parte está ligado ao ciclo de vida do todo.");
            Console.WriteLine("No exemplo, a classe 'Carro' contém um objeto 'Motor'. O 'Motor' não existe independentemente do 'Carro'.");
            Console.WriteLine("Se o objeto 'Carro' for destruído, o 'Motor' também será destruído, pois o 'Motor' faz parte integrante do 'Carro'.");
        }
    }

}
