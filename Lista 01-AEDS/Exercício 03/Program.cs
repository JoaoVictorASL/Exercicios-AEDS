using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, i, j, kDiferenca = 0, kIntersecao = 0, kUniao = 0;

            Console.Write("Informe o tamanho dos vetores: ");
            N = int.Parse(Console.ReadLine());

            double[] vetX = new double[N];
            double[] vetY = new double[N];
            double[] vetSoma = new double[N];
            double[] vetProduto = new double[N];
            double[] vetDiferenca = new double[N];
            double[] vetIntersecao = new double[N];
            double[] vetUniao = new double[2 * N]; 

            Console.WriteLine("\nPreencha o Vetor X: \n");

            for (i = 0; i < N; i++)
            {
                Console.Write($"Posição {i}: ");
                vetX[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPreencha o Vetor Y: \n");

            for (i = 0; i < N; i++)
            {
                Console.Write($"Posição {i}: ");
                vetY[i] = double.Parse(Console.ReadLine());
            }

            for (i = 0; i < N; i++)
            {
                vetDiferenca[i] = -1;
                vetIntersecao[i] = -1;
            }
            for (i = 0; i < 2 * N; i++)
            {
                vetUniao[i] = -1;
            }

            for (i = 0; i < N; i++)
            {
                vetSoma[i] = vetX[i] + vetY[i];
                vetProduto[i] = vetX[i] * vetY[i];
            }

            for (i = 0; i < N; i++)
            {
                bool encontrado = false;
                for (j = 0; j < N; j++)
                {
                    if (vetX[i] == vetY[j])
                    {
                        encontrado = true;
                        vetIntersecao[kIntersecao++] = vetX[i];
                        break;
                    }
                }

                if (!encontrado)
                {
                    vetDiferenca[kDiferenca++] = vetX[i];
                }
            }

            for (i = 0; i < N; i++)
            {
                vetUniao[kUniao++] = vetX[i];
            }
            for (i = 0; i < N; i++)
            {
                bool encontrado = false;
                for (j = 0; j < N; j++)
                {
                    if (vetY[i] == vetX[j])
                    {
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    vetUniao[kUniao++] = vetY[i];
                }
            }

            Console.WriteLine("\nSoma entre X e Y: ");
            for (i = 0; i < N; i++)
            {
                Console.Write(vetSoma[i] + " ");
            }

            Console.WriteLine("\nProduto entre X e Y: ");
            for (i = 0; i < N; i++)
            {
                Console.Write(vetProduto[i] + " ");
            }

            Console.WriteLine("\nElementos de X que não aparecem em Y: ");
            for (i = 0; i < kDiferenca; i++)
            {
                if (vetDiferenca[i] != -1)
                {
                    Console.Write(vetDiferenca[i] + " ");
                }
            }

            Console.WriteLine("\nInterseção entre X e Y: ");
            for (i = 0; i < kIntersecao; i++)
            {
                if (vetIntersecao[i] != -1)
                {
                    Console.Write(vetIntersecao[i] + " ");
                }
            }

            Console.WriteLine("\nUnião entre X e Y: ");
            for (i = 0; i < kUniao; i++)
            {
                if (vetUniao[i] != -1)
                {
                    Console.Write(vetUniao[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
