using ExeFixMetodosAbs.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExeFixMetodosAbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Tax Payer: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> list = new List<TaxPayer>();


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write("individual or company (i/c): ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healtExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    TaxPayer taxPayer = new Person(healtExpenses, name, annualIncome);

                    list.Add(taxPayer);

                }
                else
                {
                    Console.Write("Number of Employees");
                    int employeesNumber = int.Parse(Console.ReadLine());

                    TaxPayer taxPayer = new Company(employeesNumber, name, annualIncome);

                    list.Add(taxPayer);


                }

            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double soma = 0;
            foreach (TaxPayer taxPayer in list)
            {
                double tax = taxPayer.CalculateTax();
                Console.WriteLine(taxPayer.Name + ": $" + taxPayer.CalculateTax().ToString("F2", CultureInfo.InvariantCulture));
                soma += tax;
            }
            
                Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
