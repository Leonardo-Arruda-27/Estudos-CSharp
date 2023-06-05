using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace TesteAdisra
{
    class Program
    {

        //Escreva um programa em que o usuário entre com um número, que é uma posição, e obtenha como resposta qual é o número da sequência de 
        //Fibonacci na posição solicitada.* 
        //A Sequência de Fibonacci é formada começando por 0 e 1 e os demais números são a soma dos dois precedentes. (0, 1, 1, 2, 3, 5 ...)

        static void Main(string[] args)
        {
            //int[] vet = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            //int ind;

            //Console.WriteLine("Insira o indice desejado: ");
            //ind = int.Parse(Console.ReadLine());

            //for (int i = 0; i < vet.Length; i++)
            //{
            //    if (ind == vet[i])
            //    {
            //        ind = i;
            //        Console.WriteLine(ind);
            //    }
            //}

            //Uma função recebe por parâmetros uma matriz de entrada, o número de linhas e o número de colunas, processa todos os números contando
            //os pares e os ímpares e retorna a quantidade do que tiver maior quantidade de ocorrências.Escreva essa função

            int tam, impares, pares;
            impares = 0;
            pares = 0;

            int[] array = { 1, 2, 3 };

            for (int i = 0;i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Vetor: ");
            for(int i = 0; i < array[i]; i++)
            {
                if (array[i]%2== 1)
                {
                    impares++;
                }
                else
                {
                    pares++;
                }
            }
        }

       
    }
}
