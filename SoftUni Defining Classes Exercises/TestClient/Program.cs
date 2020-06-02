using System;
using System.Collections.Generic;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "End") break;
                else
                {
                    switch (input[0])
                    {
                        case "Create":
                            if (!accounts.ContainsKey(int.Parse(input[1])))
                            {
                                BankAccount current = BankAccount.Create();
                                current.Id = int.Parse(input[1]);
                                accounts.Add(int.Parse(input[1]), current);
                            }
                            else Console.WriteLine($"Account already exists");
                            break;
                        case "Deposit":
                            if (!accounts.ContainsKey(int.Parse(input[1]))) Console.WriteLine("Account does not exist");
                            else
                            {
                                accounts[int.Parse(input[1])].Deposit(int.Parse(input[2]));
                            }
                            break;
                        case "Withdraw":
                            if (!accounts.ContainsKey(int.Parse(input[1]))) Console.WriteLine("Account does not exist");
                            else
                            {
                                accounts[int.Parse(input[1])].Withdraw(int.Parse(input[2]));
                            }
                            break;
                        case "Print":
                            if (!accounts.ContainsKey(int.Parse(input[1]))) Console.WriteLine("Account does not exist");
                            else BankAccount.Print(accounts[int.Parse(input[1])]);
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
