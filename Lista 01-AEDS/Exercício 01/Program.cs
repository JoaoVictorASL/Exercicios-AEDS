using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, antecessor, cont = 1, maiorSequencia = 0;

            Console.Write("Informe um número: ");
            num = int.Parse(Console.ReadLine());

            antecessor = num;

            while (num != -1)
            {
                Console.Write("Informe outro número: ");
                num = int.Parse(Console.ReadLine());

                if (num == -1)
                    break;

                if (antecessor < num)
                {
                    cont++;
                }
                else
                {
                    if (cont > maiorSequencia)
                        maiorSequencia = cont;

                    cont = 1;
                }

                antecessor = num;
            }

            if (cont > maiorSequencia)
                maiorSequencia = cont;

            Console.WriteLine();
            Console.WriteLine($"A maior sequência foi de {maiorSequencia} números");
            Console.ReadLine();
        }
    }
}
