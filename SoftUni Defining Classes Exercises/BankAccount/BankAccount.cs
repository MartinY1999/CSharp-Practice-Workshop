using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
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
    }
}
