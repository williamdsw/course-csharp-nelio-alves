
using LastChapter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                int[] numbers = new int[] { 2, 3, 4, 5 };

                // linq expression
                var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

                foreach (int item in result)
                {
                    Console.WriteLine(item);
                }
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
