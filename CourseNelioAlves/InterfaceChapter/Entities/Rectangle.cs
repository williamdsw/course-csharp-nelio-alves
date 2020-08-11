
using System;
using System.Globalization;
using System.Text;

namespace Entities
{
    public class Rectangle : AbstractShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Rectangle color: ");
            builder.AppendLine(Color.ToString());
            builder.Append("Width: ");
            builder.AppendLine(Width.ToString("F2", CultureInfo.InvariantCulture));
            builder.Append("Height: ");
            builder.AppendLine(Height.ToString("F2", CultureInfo.InvariantCulture));
            builder.Append("Area: ");
            builder.AppendLine(Area().ToString("F2", CultureInfo.InvariantCulture));
            return builder.ToString();
        }
    }
}
