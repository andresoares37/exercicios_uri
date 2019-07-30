using System;

namespace URI1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada;
            entrada = int.Parse(Console.ReadLine());

            while (entrada != 2002)
            {
                Console.WriteLine("Senha Invalida");
                entrada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
