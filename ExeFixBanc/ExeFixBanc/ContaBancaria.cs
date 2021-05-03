using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExeFixBanc
{
    class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string Nome { get; set; }
        public double Valor { get; private set; }

        public ContaBancaria(int numeroDaConta, string nome)
        {
            NumeroDaConta = numeroDaConta ;
            Nome = nome;
            
        }

        public ContaBancaria(int numeroDaConta, string nome, double depositoInicial) : this(numeroDaConta, nome)
        {
            Deposito(depositoInicial);
        }

        public void Saque (double valorSaque)
        {
            Valor = (Valor - valorSaque) - 5;
        }

        public void Deposito(double valorDeposito) {
            Valor = (Valor + valorDeposito);
        }

        public override string ToString()
        {
            return "numero da conta:  " + NumeroDaConta.ToString() +
                ", Titular:  " + Nome.ToString() + 
                ",  saldo:   " + Valor.ToString("F2", CultureInfo.InvariantCulture );   
                }


    }
}
