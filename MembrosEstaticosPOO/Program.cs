using System;
using System.Globalization;

namespace MembrosEstaticosPOO
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferencia: {circ}");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi}");



        }
    }
}