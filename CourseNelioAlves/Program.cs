using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double other = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] values = Console.ReadLine().Split(' ');
            string name = values[0];
            char genre = char.Parse(values[1]);
            int age = int.Parse(values[2]);
            double height = double.Parse(values[3], CultureInfo.InvariantCulture);

            Console.WriteLine("\nInput:");
            Console.WriteLine(number);
            Console.WriteLine(ch);
            Console.WriteLine(other);
            Console.WriteLine("------------------------------------");
            Console.WriteLine(name);
            Console.WriteLine(genre);
            Console.WriteLine(age);
            Console.WriteLine(height);
        }
    }
}
