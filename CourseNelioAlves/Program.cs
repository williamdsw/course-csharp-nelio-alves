using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            object y = x;
            int z = (int) y; // needs cast

            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
        }
    }
}
