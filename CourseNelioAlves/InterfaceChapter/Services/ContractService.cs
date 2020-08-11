
using Entities;
using System;

namespace Services
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double baseQuote = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double updatedQuote = baseQuote + _onlinePaymentService.Interest(baseQuote, i);
                double totalQuote = updatedQuote + _onlinePaymentService.PaymentFee(updatedQuote);

                Installment installment = new Installment(dueDate, totalQuote);
                contract.AddInstallment(installment);
            }
        }
    }
}
