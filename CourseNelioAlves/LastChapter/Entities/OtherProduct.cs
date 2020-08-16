using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CourseNelioAlves.LastChapter.Entities
{
    public class OtherProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public OtherProduct(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
