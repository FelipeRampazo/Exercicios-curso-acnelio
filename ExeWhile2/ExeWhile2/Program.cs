using System;

namespace ExeWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o valor de x e y (separados por espaço): ");
            string[] vet = Console.ReadLine().Split(' ');

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro quadrante ");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro quadrante ");
                }
                else
                {
                    Console.WriteLine(" quarto quadrandte");
                }

                Console.WriteLine("digite o valor de x e y (separados por espaço): ");
                vet = Console.ReadLine().Split(' ');
                 x = int.Parse(vet[0]);
                 y = int.Parse(vet[1]);
            }
        }
    }
}
