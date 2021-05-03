using System;

namespace ExeFix01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo a = new Retangulo();

            Console.WriteLine("entre com a largura e altura do retangulo: ");

            a.Altura = double.Parse(Console.ReadLine());
            a.Largura = double.Parse(Console.ReadLine());

            double area = a.Area(a.Altura, a.Largura);
            double perimetro = a.Perimetro(a.Altura, a.Largura);
            double diagonal = a.Diagonal(a.Altura, a.Largura);

            Console.WriteLine("area: " + area);
            Console.WriteLine("perimetro: " + perimetro);
            Console.WriteLine("diagonal: " + diagonal);

           

        }
    }
}
