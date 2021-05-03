using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExeListFic
{
    class Funcionario
    {
        public int Id { get;  set; }
        public string Nome { get;  set; }

        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncrementarSalario(double porcentagem)
        {
            Salario += (Salario * (porcentagem/ 100));
        }
        public override string ToString()
        {
            return "ID:  " + Id + "  ,NOME:  "+ Nome + "  ,SALARIO  " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
