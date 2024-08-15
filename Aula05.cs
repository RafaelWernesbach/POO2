namespace Aula5
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> temperatura = new List<int>();
            for(int i = 0; i < 15; i++)
            {
                erro1:
                Console.WriteLine("Insira a temperatura do dia " + (i + 1) + "(digite sair para sair)");
                string entrada = Console.ReadLine();

                if (entrada == "sair")
                {
                    break;
                }
                else
                {
                    bool ok = int.TryParse(entrada, out int novatemp);
                    if (ok)
                    {
                        if(novatemp > 28)
                        {
                        temperatura.Add(novatemp);
                        }
                        else
                        {
                            Console.WriteLine("temperatura fora da estação");
                            goto erro1;
                        }

                    }
                }
            }
            
            int total = 0;
            for (int i = 0; i < temperatura.Count; i++)
            {
                total += temperatura[i];
                
            }

            Console.WriteLine("A media de temperatura dos ultimos 15 dias é: " + total/15);
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();

        }
    }
}
