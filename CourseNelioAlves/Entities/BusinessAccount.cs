
using System.Text;

namespace CourseNelioAlves.Entities
{
    public class BusinessAccount : Account
    {
        // PROPERTIES

        public double LoanLimit { get; set; }

        // CONSTRUCTORS

        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        // FUNCTIONS

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("BusinessAccount");
            builder.AppendLine($"Number: {Number}");
            builder.AppendLine($"Holder: {Holder}");
            builder.AppendLine($"Balance: {Balance.ToString("F2")}");
            builder.AppendLine($"Loan Limit: {LoanLimit.ToString("F2")}");
            return builder.ToString();
        }
    }
}
