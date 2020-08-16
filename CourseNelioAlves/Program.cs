
using LastChapter.Entities;
using LastChapter.Services;
using System;

namespace CourseNelioAlves
{
    public delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                double x = 10;
                double y = 12;

                // Multicast delegates
                BinaryNumericOperation op = CalculationService.ShowSum;
                op += CalculationService.ShowMax;

                Console.WriteLine($"x = {x}, y = {y}");
                op(x, y);
                //op.Invoke(x, y);
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
