using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            
            if (x < 5)
            {
                Console.WriteLine("Good Morning!");
            }
            else if (x > 5)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else
            {
                Console.WriteLine("Good Night!");
            }

            Console.WriteLine("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even!");
            }
            else
            {
                Console.WriteLine($"{number} is odd!");
            }
        }
    }
}
