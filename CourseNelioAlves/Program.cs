using CourseNelioAlves.Entities;
using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING -> subclass to superclass
            Account account1 = businessAccount;
            Account account2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account account3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // Downcasting -> superclass to subclass
            BusinessAccount businessAccount1 = (BusinessAccount) account2;
            businessAccount1.Loan(100.0);

            // prevents exception
            if (account3 is BusinessAccount)
            {
                BusinessAccount businessAccount2 = account3 as BusinessAccount;
                businessAccount2.Loan(200.0);
                Console.WriteLine(businessAccount2);
                Console.WriteLine("Loan!");
            }

            if (account3 is SavingsAccount)
            {
                SavingsAccount businessAccount2 = account3 as SavingsAccount;
                businessAccount2.UpdateBalance();
                Console.WriteLine(businessAccount2);
                Console.WriteLine("Update!");
            }

            Console.WriteLine(account);
            Console.WriteLine(businessAccount);
            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);
            Console.WriteLine(businessAccount1);
        }
    }
}
