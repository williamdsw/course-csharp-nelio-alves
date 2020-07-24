using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Calculator.Sum(1, 2);
            int sum2 = Calculator.Sum(1, 2, 3);
            int sum3 = Calculator.Sum(1, 2, 3, 4);
            int sum4 = Calculator.Sum(new int[] { 1, 2, 3, 4, 5 }); // without params
            int sum5 = Calculator.Sum(1, 2, 3, 4, 5);
            int sum6 = Calculator.Sum(1, 2, 3, 4, 5, 6, 7, 8);

            Console.WriteLine($"sum1: {sum1}");
            Console.WriteLine($"sum2: {sum2}");
            Console.WriteLine($"sum3: {sum3}");
            Console.WriteLine($"sum4: {sum4}");
            Console.WriteLine($"sum5: {sum5}");
            Console.WriteLine($"sum6: {sum6}");
        }
    }
}
