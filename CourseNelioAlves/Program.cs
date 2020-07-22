using System;
using System.Globalization;
using System.Transactions;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            // a float (4 bytes) fits in a double (8 bytes)
            float x = 4.5f;
            double y = x;

            // but a double doesn't fit in a float without casting
            double a = 5.1;
            float b = (float) a;
            int c = (int) a;

            Console.WriteLine(y);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
