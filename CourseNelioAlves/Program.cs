using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = WhoIsGreater(a, b, c);

            Console.WriteLine($"{result} is the greater");
        }

        private static int WhoIsGreater(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
