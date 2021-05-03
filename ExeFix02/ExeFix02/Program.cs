using System;
using System.Globalization;

namespace ExeFix02
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario a = new Funcionario();
            double porcentagem;

            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("salario bruto: ");
            a.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            a.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("dados " + a);

            Console.WriteLine("Digite a porcentagem para almentar o salario");
            porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            a.AumentarSalario(porcentagem);

            Console.WriteLine("dados " + a);

        }
    }
}
