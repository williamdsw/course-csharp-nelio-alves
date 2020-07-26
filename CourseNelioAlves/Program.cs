using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthdate = new DateTime(1994, 10, 2, 19, 15, 0, 500);
            string formatted = birthdate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            DateTime future = birthdate.AddYears(3);
            DateTime now = DateTime.Now;
            DateTime sevenDays = now.AddDays(7);
            TimeSpan difference = now.Subtract(birthdate);

            Console.WriteLine(birthdate);
            Console.WriteLine($"Date: {birthdate.Date}");
            Console.WriteLine($"Day: {birthdate.Day}");
            Console.WriteLine($"Day Of Week: {birthdate.DayOfWeek}");
            Console.WriteLine($"Day Of Year: {birthdate.DayOfYear}");
            Console.WriteLine($"Hour: {birthdate.Hour}");
            Console.WriteLine($"Kind: {birthdate.Kind}");
            Console.WriteLine($"Millisecond: {birthdate.Millisecond}");
            Console.WriteLine($"Minute: {birthdate.Minute}");
            Console.WriteLine($"Month: {birthdate.Month}");
            Console.WriteLine($"Seconds: {birthdate.Second}");
            Console.WriteLine($"Ticks: {birthdate.Ticks}");
            Console.WriteLine($"Time Of Day: {birthdate.TimeOfDay}");
            Console.WriteLine($"Year: {birthdate.Year}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(birthdate.ToLongDateString());
            Console.WriteLine(birthdate.ToLongTimeString());
            Console.WriteLine(birthdate.ToShortDateString());
            Console.WriteLine(birthdate.ToShortTimeString());
            Console.WriteLine(birthdate.ToLocalTime());
            Console.WriteLine(birthdate.ToUniversalTime());
            Console.WriteLine(formatted);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(future);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(now);
            Console.WriteLine(sevenDays);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(difference);
        }
    }
}
