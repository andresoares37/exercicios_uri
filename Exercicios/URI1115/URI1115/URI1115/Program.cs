using System;

namespace URI1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);

            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {



                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");

                    x = int.Parse(valores[0]);

                    y = int.Parse(valores[1]);

                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");

                    x = int.Parse(valores[0]);

                    y = int.Parse(valores[1]);
                }

                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");

                    x = int.Parse(valores[0]);

                    y = int.Parse(valores[1]);
                }

                else
                {
                    Console.WriteLine("segundo");

                    x = int.Parse(valores[0]);

                    y = int.Parse(valores[1]);
                }
                valores = Console.ReadLine().Split(' ')
            }
        }
    }
}
