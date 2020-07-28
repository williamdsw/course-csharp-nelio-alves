using CourseNelioAlves.Entities;
using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount businessAccount = new BusinessAccount(8010, "Bob Dylan", 100.0, 500.0);

            Console.WriteLine(businessAccount.Balance);
        }
    }
}
