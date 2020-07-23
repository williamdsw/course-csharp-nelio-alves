using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CourseNelioAlves
{
    class Product
    {
        private string _name;
        private double _price;
        private int _quantity;

        public Product() { }

        public string Name { get => this._name; set => this._name = value; } 
        public double Price { get => this._price; set => this._price = value; } 
        public int Quantity { get => this._quantity; set => this._quantity = value; } 

        public double TotalInStock()
        {
            return _price * _quantity;
        }

        public override string ToString()
        {
            return $"{_name}, $ {_price.ToString ("F2", CultureInfo.InvariantCulture)}, {_quantity} quantity(ies), total: {TotalInStock().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
