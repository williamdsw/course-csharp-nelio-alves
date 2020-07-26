using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan min = TimeSpan.MinValue;
            TimeSpan max = TimeSpan.MaxValue;
            TimeSpan zero = TimeSpan.Zero;
            TimeSpan timeSpan = new TimeSpan(10, 19, 15, 0, 500);
            TimeSpan another = new TimeSpan(1, 30, 10);
            TimeSpan other = new TimeSpan(0, 10, 5);
            TimeSpan sum = another.Add(other);
            TimeSpan substract = another.Subtract(other);
            TimeSpan multi = other.Multiply(2.0);
            TimeSpan div = other.Divide(2.0);

            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Zero: {zero}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(timeSpan);
            Console.WriteLine($"Days: {timeSpan.Days}");
            Console.WriteLine($"Hours: {timeSpan.Hours}");
            Console.WriteLine($"Minutes: {timeSpan.Minutes}");
            Console.WriteLine($"Milliseconds: {timeSpan.Milliseconds}");
            Console.WriteLine($"Seconds: {timeSpan.Seconds}");
            Console.WriteLine($"Ticks: {timeSpan.Ticks}"); 
            Console.WriteLine($"TotalDays: {timeSpan.TotalDays}");
            Console.WriteLine($"TotalHours: {timeSpan.TotalHours}");
            Console.WriteLine($"TotalMinutes: {timeSpan.TotalMinutes}");
            Console.WriteLine($"TotalMilliseconds: {timeSpan.TotalMilliseconds}");
            Console.WriteLine($"TotalSeconds: {timeSpan.TotalSeconds}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(another);
            Console.WriteLine(other);
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"difference: {substract}");
            Console.WriteLine($"multiply: {multi}");
            Console.WriteLine($"division: {div}");
        }
    }
}
