using System;

namespace Exercício_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, numeroAtual = 1;

            do
            {
                Console.Write("Informe um Número positivo: ");
                N = int.Parse(Console.ReadLine());

            } while (N <= 0);

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(numeroAtual + " ");
                    numeroAtual++;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}