
using System.Globalization;
using System.Threading.Channels;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] vet = Console.ReadLine().Split(';');

            //string um = vet[0];
            //string dois = vet[1];
            //string tres = vet[2];

            //Console.WriteLine(um);
            //Console.WriteLine(dois);
            //Console.WriteLine(tres);
            //Console.WriteLine();

            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string[] ve = Console.ReadLine().Split(' ');
            //string nome = ve[0];
            //char sexo = char.Parse(ve[1]);
            //int idade = int.Parse(ve[2]);
            //double altura = double.Parse(ve[3], CultureInfo.InvariantCulture);

            //Console.WriteLine("Voce digitou: ");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(d);
            //Console.WriteLine();

            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura);


            //Console.WriteLine("Entre com o seu nome completo: ");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Quantos quartos tem na sua casa? ");
            //int qts = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com o preço de um produto: ");
            //double preco = double.Parse(Console.ReadLine());

            //Console.WriteLine("Entre seu ultimo nome, idade e altura: ");
            //int idade ;
            //string[] ve = Console.ReadLine().Split(' ');
            //ve[0] = nome;


            //int hora = 01;

            //if (hora >=18)
            //{
            //    Console.WriteLine("Boa noite chefia");
            //}
            //else if(hora >= 12)
            //{
            //    Console.WriteLine("Tarde linda padrinho");
            //}
            //else
            //{
            //    Console.WriteLine("Fala baixo ai que ainda ta cedo!");
            //}

            //string login = "leo@gmail.com";
            //string senha = "1234";

            //Console.WriteLine("Insira seu email: ");
            //string em = Console.ReadLine();

            //Console.WriteLine("Insira sua senha: ");
            //string sn = Console.ReadLine();

            //if (em == login && sn == senha)
            //{
            //    Console.Write("Logado com sucesso!");
            //}
            //else
            //{
            //    Console.WriteLine("Login Invalido");
            //}


            int[] al = {1,2,3,4,5,6,7};
            for(int i = 0; i < al.Length; i++)
            {
                al[i] = i;
                Console.WriteLine(i);
            }

        }
    }
}