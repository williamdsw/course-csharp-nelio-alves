using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of triangule that you want: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1)
            {
                int greatestTriangule = 0;
                double greatestArea = 0;

                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine($"Input values of {i}# triangule:");
                    double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Triangle triangle = new Triangle(a, b, c);
                    if (greatestTriangule == 0)
                    {
                        greatestTriangule++;
                        greatestArea = triangle.GetArea();
                    }
                    else if (triangle.GetArea() > greatestArea)
                    {
                        greatestArea = triangle.GetArea();
                        greatestTriangule = i;
                    }

                    Console.WriteLine($"Area: {triangle.GetArea ().ToString ("F4", CultureInfo.InvariantCulture)}");
                }

                Console.WriteLine($"{greatestTriangule}º triangule is the greatest with area of {greatestArea.ToString ("F4", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
