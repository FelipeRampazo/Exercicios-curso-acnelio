using System;
using System.Collections.Generic;
using System.Text;
using ExeExec.Entities.Exceptions;

namespace ExeExec.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double  Balance { get; set; }

        public double WithdrawLimit { get; set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }

        public void Withdraw(double ammount)
        {
            
            if (ammount > Balance)
            {
                throw new DomainException("valor do saque é maior que o valor do saldo");
            }
            if (ammount > WithdrawLimit)
            {
                throw new DomainException("valor não pode ser maior que o limite de saque ");
            }

            Balance -= ammount;
        }
    }
}
