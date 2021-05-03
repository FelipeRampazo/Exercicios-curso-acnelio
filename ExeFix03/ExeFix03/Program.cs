using System;

namespace ExeFix03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.WriteLine("digite o nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("digite as notas do aluno");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota final: " + a.NotaFinal());
            Console.WriteLine(a.VerificarAprovacao());

            if (a.VerificarAprovacao() == "reprovado"){

                Console.WriteLine("pontos faltando: " + a.PontosFaltando());
            }
            
           
            
            
        }
    }
}
