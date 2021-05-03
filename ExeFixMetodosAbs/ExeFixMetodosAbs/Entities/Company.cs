using System;
using System.Collections.Generic;
using System.Text;

namespace ExeFixMetodosAbs.Entities
{
    class Company : TaxPayer
    {
        public int EmployeesNumber { get; set; }

        public Company()
        {
        }

        public Company(int employeesNumber, string name, double annualIncome) : base (name, annualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double CalculateTax()
        {
            double resultado = 0;

                if (EmployeesNumber > 10)
            {
                resultado = AnnualIncome * 0.14;

            }
                else
            {
                resultado = AnnualIncome * 0.16;
            }

            return resultado;
        }
    }
}
