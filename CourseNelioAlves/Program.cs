using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an number: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double sqrt = Math.Sqrt(x);
                Console.WriteLine(sqrt.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Input another number: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"{x} is a negative number!");
        }
    }
}
