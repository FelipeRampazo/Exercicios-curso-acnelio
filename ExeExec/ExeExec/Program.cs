using ExeExec.Entities;
using System;
using System.Globalization;
using ExeExec.Entities.Exceptions;

namespace ExeExcep
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Inicial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter ammout for withdraw: ");
                double ammount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(ammount);

                Console.WriteLine("New balance: " + account.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }

            catch (DomainException e)
            {
                Console.WriteLine("excessao : "+ e.Message );
            }


        }
    }
}
