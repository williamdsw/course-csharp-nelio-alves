using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a += b --> {a += b}");
            Console.WriteLine($"a -= b --> {a -= b}");
            Console.WriteLine($"a *= b --> {a *= b}");
            Console.WriteLine($"a /= b --> {a /= b}");
            Console.WriteLine($"a %= b --> {a %= b}");
            Console.WriteLine($"a++ --> {a++}");
            Console.WriteLine($"a-- --> {a--}");
            Console.WriteLine($"++a --> {++a}");
            Console.WriteLine($"--a --> {--a}");
        }
    }
}
