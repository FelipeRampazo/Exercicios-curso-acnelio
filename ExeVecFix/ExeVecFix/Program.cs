using System;
using System.Globalization;
namespace ExeVecFix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string nome, email;
            int quarto;
            Aluguel[] a = new Aluguel[10];

            for (int i = 0; i < n; i++) {
                Console.Write("Name: ");
                nome = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());

                a[quarto] = new Aluguel { Nome = nome, Email = email, Quarto = quarto };              

             
            }

            for (int i = 0; i < 10; i++)
            {
                if (a[i] != null)
                Console.WriteLine(a[i].ToString());

            }

        }
    }
}
