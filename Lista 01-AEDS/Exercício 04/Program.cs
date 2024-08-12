using System;

namespace Exercício_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCandidatos, voto, maisVotado = 0, menosVotado = 0, votosNulos = 0, i;

            Console.Write("Informe a quantidade de Candidatos a representante: ");
            numCandidatos = int.Parse(Console.ReadLine());

            Console.WriteLine();
            string[] nomes = new string[numCandidatos];
            int[] votos = new int[numCandidatos]; 

            for (i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Informe o nome do Candidato número {i}: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine();
            for (i = 0; i < 5; i++)
            {
                Console.Write("Informe o número do Candidato que deseja votar: ");
                voto = int.Parse(Console.ReadLine());

                if (voto >= numCandidatos || voto < 0) 
                {
                    votosNulos++;
                }
                else
                {
                    votos[voto]++;
                }
            }

            for (i = 1; i < votos.Length; i++)
            {
                if (votos[i] > votos[maisVotado])
                {
                    maisVotado = i;
                }

                if (votos[i] < votos[menosVotado])
                {
                    menosVotado = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"O candidato {nomes[maisVotado]} foi o mais votado com um total de {votos[maisVotado]} votos!");
            Console.WriteLine($"O candidato {nomes[menosVotado]} foi o menos votado com um total de {votos[menosVotado]} votos!");
            Console.WriteLine($"Votos nulos: {votosNulos}");
            Console.ReadLine();
        }
    }
}
