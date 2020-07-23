using System;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CourseNelioAlves
{
    class Program
    {
        static double PI = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Input radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circumference = Circumference(radius);
            double volume = Volume(radius);

            Console.WriteLine("Circumference: {0}", circumference.ToString ("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: {0}", volume.ToString ("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: {0}", PI.ToString ("F2", CultureInfo.InvariantCulture));
        }

        private static double Circumference (double radius)
        {
            return 2.0 * PI * radius;
        }

        private static double Volume (double radius)
        {
            return 4.0 / 3.0 * PI * Math.Pow(radius, 3);
        }
    }
}
