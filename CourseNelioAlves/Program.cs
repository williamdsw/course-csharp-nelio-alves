using CourseNelioAlves.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1002, "Maria", 500.0, 400.00));
            accounts.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1004, "Anna", 500.0, 500.00));

            double sum = accounts.Sum(acc => acc.Balance);
            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            accounts.ForEach(acc =>
            {
                acc.Withdraw(10.0);
                Console.Write("Updated balance for account ");
                Console.WriteLine(acc.Number + " : " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            });
        }
    }
}
