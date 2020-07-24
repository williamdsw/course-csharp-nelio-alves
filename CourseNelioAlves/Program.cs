using System;
using System.Globalization;
using System.Linq;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of persons: ");
            int number = int.Parse(Console.ReadLine());

            double[] heights = new double[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Input height for {i + 1} person: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                heights[i] = height;
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Min: {0}", heights.Min().ToString ("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Max: {0}", heights.Max().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Average: {0}", heights.Average().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
