﻿
using System.Globalization;

namespace LastChapter.Entities
{
    public class Product /*: IComparable<Product>*/
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        /*public int CompareTo(Product other)
        {
            //return Name.ToUpper().CompareTo(other.Name.ToUpper());
            return Price.CompareTo(other.Price);
        }*/
    }
}
