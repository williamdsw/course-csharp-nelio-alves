using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Entities.Old
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product() { }

        public Product(string name, double price) : this()
        {
            Name = name;
            Price = price;
            Quantity = 0;
        }

        public Product(string name, double price, int quantity) : this(name, price)
        {
            Quantity = quantity;
        }

        public double TotalInStock()
        {
            return Price * Quantity;
        }

        public void AddQuantityToStock (int quantity)
        {
            this.Quantity += quantity;
        }

        public void RemoveQuantityFromStock (int quantity)
        {
            if (Quantity != 0 || quantity != 0)
            {
                Quantity -= quantity;
            }
        }

        public override string ToString()
        {
            return $"{Name}, $ {Price.ToString ("F2", CultureInfo.InvariantCulture)}, {Quantity} quantity(ies), total: {TotalInStock().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
