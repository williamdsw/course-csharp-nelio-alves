
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
                PrintService<int> printService1 = new PrintService<int>();

                Console.Write("How many integers ? ");
                int count1 = int.Parse(Console.ReadLine());
                for (int i = 0; i < count1; i++)
                {
                    int value = int.Parse(Console.ReadLine());
                    printService1.AddValue(value);
                }

                printService1.Print();
                Console.WriteLine($"\nFirst: {printService1.First()}");
                
                PrintService<string> printService2 = new PrintService<string>();

                Console.Write("\nHow many names ? ");
                int count2 = int.Parse(Console.ReadLine());
                for (int i = 0; i < count2; i++)
                {
                    string value = Console.ReadLine();
                    printService2.AddValue(value);
                }

                printService2.Print();
                Console.WriteLine($"\nFirst: {printService2.First()}");
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
