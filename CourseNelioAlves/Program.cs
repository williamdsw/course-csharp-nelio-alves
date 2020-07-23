using System;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circumference = Calculator.Circumference(radius);
            double volume = Calculator.Volume(radius);

            Console.WriteLine("Circumference: {0}", circumference.ToString ("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: {0}", volume.ToString ("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: {0}", Math.PI.ToString ("F2", CultureInfo.InvariantCulture));
        }

        
    }
}
