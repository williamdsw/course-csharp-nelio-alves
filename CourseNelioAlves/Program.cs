using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime begin = new DateTime(1994, 10, 2);
            DateTime end = new DateTime(2010, 10, 2);

            TimeSpan timeSpan = new TimeSpan(0, 1, 30);
            TimeSpan duration = new TimeSpan(end.Ticks - begin.Ticks);
            TimeSpan fromDays = TimeSpan.FromDays(1.5);

            Console.WriteLine(timeSpan);
            Console.WriteLine($"Ticks: {timeSpan.Ticks}");
            Console.WriteLine(duration);
            Console.WriteLine($"Ticks: {duration.Ticks}");
            Console.WriteLine(fromDays);
        }
    }
}
