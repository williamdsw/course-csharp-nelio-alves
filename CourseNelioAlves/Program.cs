using System;
using System.Globalization;
using System.Linq;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of products: ");
            int number = int.Parse(Console.ReadLine());

            Product[] products = new Product[number];
            double sum = 0.0;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i + 1}# product data: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(name, price, quantity);
                products[i] = product;
                sum += price;
            }

            double avg = (sum / number);

            Console.WriteLine("-------------------");
            Console.WriteLine("Average: {0}", avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
