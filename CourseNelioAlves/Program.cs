using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers your will input? ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                Console.Write($"{i}# value: ");
                int value = int.Parse(Console.ReadLine());
                sum += value;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
