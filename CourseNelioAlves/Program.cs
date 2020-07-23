using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Input product's data: ");
            Console.Write("Name: ");
            product.Name = Console.ReadLine();
            Console.Write("Price: ");
            product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Stock quantity: ");
            product.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Product's data: {0}", product);
            Console.WriteLine("-------------------------------------------------");

            Console.Write("\nInput the quantity of products to be added to stock: ");
            int quantity = int.Parse(Console.ReadLine());
            product.AddQuantityToStock(quantity);
            Console.WriteLine("Product's data: {0}", product);

            Console.Write("\nInput the quantity of products to be removed to stock: ");
            quantity = int.Parse(Console.ReadLine());
            product.RemoveQuantityFromStock(quantity);
            Console.WriteLine("Product's data: {0}", product);
        }
    }
}
