using CourseNelioAlves.Entities;
using CourseNelioAlves.Structs;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Color: (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (type == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Shape rectangle = new Rectangle(color, height, width);
                    shapes.Add(rectangle);
                }
                else if (type == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Shape circle = new Circle(color, radius);
                    shapes.Add(circle);
                }
            }

            Console.WriteLine("\nSHAPE AREAS:");
            shapes.ForEach(shape =>
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            });
        }
    }
}
