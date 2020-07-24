using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int result;

            // Calculator.Triplicate(ref number);
            Calculator.Triplicate(number, out result);
            Console.WriteLine($"origin: {number}, result: {result}");
        }
    }
}
