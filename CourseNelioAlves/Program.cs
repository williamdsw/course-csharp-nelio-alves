using CourseNelioAlves.Entities;
using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1001, "Alex", 500.00);
            Account account2 = new SavingsAccount(1002, "Maria", 500.00, 0.01);
            Account account3 = new BusinessAccount(1003, "John", 500.00, 100.00);

            account1.Withdraw(10.0);
            account2.Withdraw(10.0);
            account3.Withdraw(10.0);

            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);
        }
    }
}
