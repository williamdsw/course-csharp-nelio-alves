
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
            double amount = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                amount += _onlinePaymentService.PaymentFee(amount);
                amount += _onlinePaymentService.Interest(amount, i);

                Installment installment = new Installment(dueDate, amount);
                contract.AddInstallment(installment);

                amount = contract.TotalValue / months;
            }
        }
    }
}
