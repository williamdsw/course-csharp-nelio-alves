
using Entities;
using Enums;
using Services;
using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                IShape circle = new Circle() { Radius = 2.0, Color = Color.Blue };
                IShape rectangle = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Red };

                Console.WriteLine(circle);
                Console.WriteLine(rectangle);
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
