using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition1 = 2 > 3 && 4 != 5;
            bool condition2 = 2 > 3 || 4 != 5;
            bool condition3 = !(2 > 3) && 4 != 5;
            bool condition4 = 10 < 5;
            bool condition5 = condition1 || condition2 && condition3;

            Console.WriteLine($"2 > 3 && 4 != 5: {condition1}");
            Console.WriteLine($"2 > 3 || 4 != 5: {condition2}");
            Console.WriteLine($"!(2 > 3) && 4 != 5: {condition3}");
            Console.WriteLine($"10 < 5: {condition4}");
            Console.WriteLine($"condition1 || condition2 && condition3: {condition5}");
        }
    }
}
