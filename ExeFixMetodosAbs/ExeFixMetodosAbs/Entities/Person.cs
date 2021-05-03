using System;
using System.Collections.Generic;
using System.Text;

namespace ExeFixMetodosAbs.Entities
{
    class Person : TaxPayer
    {
        public Double HealtExpenses { get; set; }

        public Person()
        {
        }

        public Person(double healtExpenses, string name , double annualIncome) : base(name, annualIncome)
        {
            HealtExpenses = healtExpenses;
        }

        public override double CalculateTax()
        {
            double result = 0;

            if (AnnualIncome < 20000)
            {
                result = (AnnualIncome * 0.15) - (HealtExpenses * 0.5);
            }
            else
            {
                result = (AnnualIncome * 0.25) - (HealtExpenses * 0.5);
            }


            return result;
        }
    }
}
