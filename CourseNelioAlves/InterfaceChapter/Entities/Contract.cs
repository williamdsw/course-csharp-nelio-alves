
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; } = new List<Installment>();

        public Contract() { }
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Installments: ");

            Installments.ForEach(installment => 
            {
                builder.AppendLine(installment.ToString());
            });

            return builder.ToString();
        }
    }
}
