using System;
using System.Collections.Generic;
using System.Text;

namespace ExeFix01
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area (double altura, double largura)
        {
            return altura * largura;
        }

        public double Perimetro (double altura, double largura)
        {
            return altura * 2 + largura * 2;
        }

        public double Diagonal (double altura, double largura)
        {
            return Math.Sqrt((Math.Pow(altura, 2)) + (Math.Pow(largura, 2)));
            
        }

    }
}
