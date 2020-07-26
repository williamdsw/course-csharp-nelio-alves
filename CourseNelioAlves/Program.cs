using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an integer: ");
            int number = int.Parse(Console.ReadLine());
            string day;

            switch (number)
            {
                case 1: { day = "Sunday"; break; }
                case 2: { day = "Monday"; break; }
                case 3: { day = "Tuesday"; break; }
                case 4: { day = "Wednesday"; break; }
                case 5: { day = "Thursday"; break; }
                case 6: { day = "Friday"; break; }
                case 7: { day = "Saturday"; break; }
                default: { day = "Invalid Number"; break; }
            }

            Console.WriteLine($"day: {day}");
        }
    }
}
