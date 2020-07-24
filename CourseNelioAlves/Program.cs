using System;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input product data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, quantity);
            // Product product = new Product (name, price);
            // Product product = new Product ();

            Console.WriteLine("Product: {0}", product);
        }
    }
}
