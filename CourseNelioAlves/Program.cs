using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime birthdate = new DateTime(1994, 10, 2);
            DateTime today = DateTime.Today;
            DateTime utcNow = DateTime.UtcNow;
            DateTime custom = DateTime.Parse("1994-10-02 19:15:00");
            DateTime otherCustom = DateTime.Parse("02/10/1994 19:15:00");
            DateTime exact = DateTime.ParseExact("1994-10-02", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(now);
            Console.WriteLine(birthdate);
            Console.WriteLine(today);
            Console.WriteLine(utcNow);
            Console.WriteLine(custom);
            Console.WriteLine(otherCustom);
            Console.WriteLine(exact);
            Console.WriteLine($"Now Ticks: {now.Ticks}");
        }
    }
}
