using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            int local = 19; // needs to be initialized
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = 0;

            Console.WriteLine($"Price: {price:F2}");

            if (price >= 100.00)
            {
                double discount = price * 0.1f;
                total = price - discount;
                Console.WriteLine($"Discount: {discount:F2}");
            }

            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
