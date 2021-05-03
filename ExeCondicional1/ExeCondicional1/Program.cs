using System;

namespace ExeCondicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com um numero inteiro");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("O numero é positivo");
            }
            else
            {
                Console.WriteLine("o numero é negativo");
            }

        }
    }
}
