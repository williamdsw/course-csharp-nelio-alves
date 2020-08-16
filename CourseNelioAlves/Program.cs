
using LastChapter.Entities;
using LastChapter.Services;
using System;

namespace CourseNelioAlves
{
    public delegate double BinaryNumericOperation(double n1, double n2);
    public delegate double SingleNumericOperation(double n1);

    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                double x = 10;
                double y = 12;
                double max = CalculationService.Max(x, y);
                double sum = CalculationService.Sum(x, y);
                double square = CalculationService.Square(x);

                Console.WriteLine($"x = {x}, y = {y}");
                Console.WriteLine("----- COMMON -----");
                Console.WriteLine($"max = {max}");
                Console.WriteLine($"sum = {sum}");
                Console.WriteLine($"square of x = {square}");

                BinaryNumericOperation opMax = CalculationService.Max;
                BinaryNumericOperation opSum = new BinaryNumericOperation(CalculationService.Sum);
                SingleNumericOperation opSquare = CalculationService.Square;
                max = opMax(x, y);
                sum = opSum(x, y);
                square = opSquare.Invoke(x);

                Console.WriteLine("----- DELEGATES -----");
                Console.WriteLine($"max = {max}");
                Console.WriteLine($"sum = {sum}");
                Console.WriteLine($"square of x = {square}");
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
