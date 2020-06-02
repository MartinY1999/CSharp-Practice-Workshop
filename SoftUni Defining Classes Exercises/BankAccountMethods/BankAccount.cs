using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountMethods
{
    public class BankAccount
    {
        private int id;
        private decimal balance;
        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public decimal Balance
        {
            get => this.balance;
            set => this.balance = value;
        }
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
        public override string ToString()
        {
            return $"Account {this.Id}, balance {this.Balance}";
        }
    }
}
