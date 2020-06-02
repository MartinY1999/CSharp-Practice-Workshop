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
        public static BankAccount Create()
        {
            return new BankAccount();
        }
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            if (this.Balance >= amount)
            {
                return this.Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
                return 0;
            }
        }
        public static void Print(BankAccount account)
        {
            Console.WriteLine($"Account ID{account.Id}, balance {account.Balance:F2}");
        }
    }
}
