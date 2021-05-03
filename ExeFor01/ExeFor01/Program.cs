using System;

namespace ExeFor01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" digite o valor de x ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine( i );
                }
            }
        }
    }
}
