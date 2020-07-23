using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool isLessThanTen = a < 10;
            bool isLessThanTwenty = a < 20;
            bool isGreaterThanTen = a > 10;
            bool isGreaterThanFive = a > 5;
            bool isLessOrEqualToTen = a <= 10;
            bool isGreaterOrEqualToTen = a >= 10;
            bool isEqualsToTen = a == 10;
            bool isDifferentOfTen = a != 10;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"a < 10 ? {isLessThanTen}");
            Console.WriteLine($"a < 20 ? {isLessThanTwenty}");
            Console.WriteLine($"a > 10 ? {isGreaterThanTen}");
            Console.WriteLine($"a > 5 ? {isGreaterThanFive}");
            Console.WriteLine($"a <= 10 ? {isLessOrEqualToTen}");
            Console.WriteLine($"a >= 10 ? {isGreaterOrEqualToTen}");
            Console.WriteLine($"a == 10 ? {isEqualsToTen}");
            Console.WriteLine($"a != 10 ? {isDifferentOfTen}");
        }
    }
}
