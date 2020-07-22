using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int z = 2;
            int sum = x + y + z;
            int substract = x - y - z;
            int multiplication = x * y * z;
            int division = x / y / z;
            int mod = x % y % z;
            int exp1 = x + y * z;
            int exp2 = (x + y) * z;
            int exp3 = 17 % 3;
            double exp4 = 10.0 / 8.0;

            // baskhara
            double a = 1.0;
            double b = -3.0;
            double c = -4.0;
            double delta = Math.Pow (b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"substract = {substract}");
            Console.WriteLine($"multiplication = {multiplication}");
            Console.WriteLine($"division = {division}");
            Console.WriteLine($"mod = {mod}");
            Console.WriteLine($"exp1 = {exp1}");
            Console.WriteLine($"exp2 = {exp2}");
            Console.WriteLine($"exp3 = {exp3}");
            Console.WriteLine($"exp4 = {exp4}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            Console.WriteLine($"delta = {delta}");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
    }
}
