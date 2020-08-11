
using Services;
using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                PrintService printService = new PrintService();

                Console.Write("How many values ? ");
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    int value = int.Parse(Console.ReadLine());
                    printService.AddValue(value);
                }

                printService.Print();
                Console.WriteLine($"\nFirst: {printService.First()}");
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
