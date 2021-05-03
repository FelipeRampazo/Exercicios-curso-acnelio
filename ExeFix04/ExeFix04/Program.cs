using System;
using System.Globalization;

namespace ExeFix04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("quantos dolares vai comprar ?");
            double dol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("valor a ser pago  em reais: " + Conversor.Converter(dol, cotacao).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
