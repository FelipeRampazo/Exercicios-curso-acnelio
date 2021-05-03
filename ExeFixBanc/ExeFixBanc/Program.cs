using System;
using System.Globalization;

namespace ExeFixBanc
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria a ;
            Console.Write("entre com o numero da conta ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("entre com o nome da conta ");
            string nome = Console.ReadLine();

            Console.Write("havera deposito inicial s/n ");
            string verificaDeposioIcinial = (Console.ReadLine());

            if (verificaDeposioIcinial == "s")
            {
                Console.Write("Entre com o valor do deposito ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                a = new ContaBancaria(numero,nome,depositoInicial);
              
            }

            else
            {
                a = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("dados da conta: ");
            Console.WriteLine(a.ToString());

            Console.WriteLine("entre com o valor do deposito ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Deposito(deposito);

            Console.WriteLine("dados da conta atualizados ");
            Console.WriteLine(a.ToString());

            Console.WriteLine("entre com o valor para saque ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Saque(saque);

            Console.WriteLine("dados da conta atualizados ");
            Console.WriteLine(a.ToString());

        }
    }
}
