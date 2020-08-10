
using System.Globalization;
using System.Text;

namespace Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice() { }
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Basic payment: ");
            builder.AppendLine(BasicPayment.ToString("F2", CultureInfo.InvariantCulture));
            builder.AppendLine("Tax: ");
            builder.AppendLine(Tax.ToString("F2", CultureInfo.InvariantCulture));
            builder.AppendLine("Total Payment: ");
            builder.AppendLine(TotalPayment.ToString("F2", CultureInfo.InvariantCulture));
            return builder.ToString();
        }
    }
}
