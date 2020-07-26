using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthdate = new DateTime(1994, 10, 2, 19, 15, 0);
            DateTime birthdateLocal = new DateTime(1994, 10, 2, 19, 15, 0, DateTimeKind.Local);
            DateTime birthdateUtc = new DateTime(1994, 10, 2, 19, 15, 0, DateTimeKind.Utc);
            DateTime other = DateTime.Parse("1994-10-02 19:15:00");
            DateTime another = DateTime.Parse("1994-10-02T19:15:00Z");

            PrintDateProperties(birthdate);
            PrintDateProperties(birthdateLocal);
            PrintDateProperties(birthdateUtc);
            PrintDateProperties(other);
            PrintDateProperties(another);
        }

        private static void PrintDateProperties (DateTime dateTime)
        {
            Console.WriteLine($"Birthdate: {dateTime}");
            Console.WriteLine($"Kind: {dateTime.Kind}");
            Console.WriteLine($"Local: {dateTime.ToLocalTime()}");
            Console.WriteLine($"Universal: {dateTime.ToUniversalTime()}");
            Console.WriteLine($"ISO 8601 Wrong: {dateTime.ToString("yyyy-MM-ddTHH:mm:ssZ")}");
            Console.WriteLine($"ISO 8601 Right: {dateTime.ToUniversalTime ().ToString("yyyy-MM-ddTHH:mm:ssZ")}");
            Console.WriteLine();
        }
    }
}
