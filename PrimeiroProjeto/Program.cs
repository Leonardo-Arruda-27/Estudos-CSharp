namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Coé mané, C# é bacaninha!");
            Console.WriteLine();

            string nome = "leo";
            int idade = 20;
            bool eDeMaior = false;

            if (idade >= 18)
            {
                eDeMaior = true;
                Console.WriteLine("Parabéns {0} você é de maior! {1}", nome, eDeMaior);
            }
            else
            {
                Console.WriteLine($"Vaza daqui {nome}! Sua criançinha... {eDeMaior}");
            }

            Console.WriteLine();
            
            string a = "abc";
            Console.WriteLine(a);

            a += "def";
            Console.WriteLine(a);

            double aa= 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * aa* c;

            double x1 = (-b + Math.Sqrt(delta)) / ((2.0 * aa));

            Console.WriteLine(x1);


        }
    }
}