using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExeFix02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

       public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += ((porcentagem / 100) * SalarioBruto);
        }

        public override string ToString()
        {
            return ("nome: " + Nome + ",  $" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)); 
        }

    }
}
