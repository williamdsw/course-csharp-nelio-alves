using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            // doesn't need to be initialized to be used, but needs to print out
            Point point = new Point();
            point.X = 10;
            point.X = 20;

            Console.WriteLine("Point: {0}", point);
        }
    }
}
