using System;
using System.Collections.Generic;
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
    }
}
