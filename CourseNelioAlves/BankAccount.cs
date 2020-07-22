
namespace CourseNelioAlves
{
    class BankAccount
    {
        private double _balance;
        public string Owner { get; set; }

        public void Deposit (double quantity)
        {
            _balance += quantity;
        }

        public double GetBalance ()
        {
            return this._balance;
        }
    }
}
