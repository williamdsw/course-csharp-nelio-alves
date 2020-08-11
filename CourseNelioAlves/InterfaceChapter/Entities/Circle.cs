
using System;
using System.Globalization;
using System.Text;

namespace Entities
{
    public class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Circle color: ");
            builder.AppendLine(Color.ToString());
            builder.Append("Radius: ");
            builder.AppendLine(Radius.ToString("F2", CultureInfo.InvariantCulture));
            builder.Append("Area: ");
            builder.AppendLine(Area().ToString("F2", CultureInfo.InvariantCulture));
            return builder.ToString();
        }
    }
}
