using System.Text;

namespace CourseNelioAlves.Entities
{
    public class Account
    {
        // PROPERTIES

        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        // CONSTRUCTORS

        public Account() { }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // FUNCTIONS

        // virtual : enables override in subclass
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Account");
            builder.AppendLine($"Number: {Number}");
            builder.AppendLine($"Holder: {Holder}");
            builder.AppendLine($"Balance: {Balance.ToString("F2")}");
            return builder.ToString();
        }
    }
}
