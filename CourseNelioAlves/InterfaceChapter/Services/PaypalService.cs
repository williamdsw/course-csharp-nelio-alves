
namespace Services
{
    public class PaypalService : IOnlinePaymentService
    {
        private const double simpleInterestRate = 0.01;
        private const double paymentTaxRate = 0.02;

        public double PaymentFee(double amount)
        {
            return amount * paymentTaxRate;
        }

        public double Interest(double amount, int months)
        {
            return amount * simpleInterestRate * months;
        }
    }
}
