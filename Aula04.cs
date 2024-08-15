namespace Aula4
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();
            while (true)
            {
                Console.WriteLine("Insira uma idade(digite sair para sair)");
                string entrada = Console.ReadLine();

                if (entrada == "sair")
                {
                    break;
                }
                else
                {
                    bool ok = int.TryParse(entrada, out int novaidade);
                    if (ok)
                    {
                        idades.Add(novaidade);

                    }
                }
            }
            int A = 0, B = 0, C = 0, D = 0, E = 0;
            // 01 - 60
            for (int i = 0; i < idades.Count; i++)
            {
                if (idades[i] > 0 && idades[i] <= 15)
                {
                    A++;
                }
                else if (idades[i] > 15 && idades[i] <= 30)
                {
                    B++;
                }
                else if (idades[i] > 30 && idades[i] <= 45)
                {
                    C++;
                }
                else if (idades[i] > 45 && idades[i] <= 60)
                {
                    D++;
                }
                else if (idades[i] > 60)
                {
                    E++;
                }
            }
            Console.WriteLine("A = " + (100 * A) / idades.Count + "%");
            Console.WriteLine("B = " + (100 * B) / idades.Count + "%");
            Console.WriteLine("C = " + (100 * C) / idades.Count + "%");
            Console.WriteLine("D = " + (100 * D) / idades.Count + "%");
            Console.WriteLine("E = " + (100 * E) / idades.Count + "%");
        }
    }
}
