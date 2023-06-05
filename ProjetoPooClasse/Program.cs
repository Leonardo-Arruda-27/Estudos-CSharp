using System.Globalization;

namespace ProjetoPooClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo trianguloX = new Triangulo();
            Triangulo trianguloY = new Triangulo();


            Console.WriteLine("\nEntre com as medidas do triangulo X: ");
            trianguloX.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloX.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloX.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre com as medidas do triangulo Y: ");
            trianguloY.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloY.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloY.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = trianguloX.CalculaAreaTriangulo();
            double areaY = trianguloY.CalculaAreaTriangulo();

            Console.WriteLine($"Área de X = {areaX}\n");
            Console.WriteLine($"Área de Y = {areaY}\n");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}