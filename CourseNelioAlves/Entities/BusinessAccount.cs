
namespace CourseNelioAlves.Entities
{
    public class BusinessAccount : Account
    {
        // PROPERTIES

        public double LoanLimit { get; set; }

        // CONSTRUCTORS

        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        // FUNCTIONS

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
