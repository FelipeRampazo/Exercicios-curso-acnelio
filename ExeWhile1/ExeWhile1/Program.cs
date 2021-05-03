using System;

namespace ExeWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha:");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");

                Console.WriteLine("Digite novamente:");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
           
        }

    }
}
