using System;
using System.Collections.Generic;
using System.Text;

namespace CourseNelioAlves.Entities
{
    public class SavingsAccount : Account
    {
        // PROPERTIES

        public double InterestRate { get; set; }

        // CONSTRUCTOR

        public SavingsAccount() { }
        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        // FUNCTIONS

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void UpdateBalance()
        {
            Balance += (Balance * InterestRate);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("SavingsAccount");
            builder.AppendLine($"Number: {Number}");
            builder.AppendLine($"Holder: {Holder}");
            builder.AppendLine($"Balance: {Balance.ToString("F2")}");
            builder.AppendLine($"Interest Rate: {InterestRate.ToString("F2")}");
            return builder.ToString();
        }
    }
}
