
using LastChapter.Entities;
using System;
using System.Collections.Generic;

namespace CourseNelioAlves
{
    class Program
    {
        private const int globalValue = 3;

        static void Main(string[] args)
        {
			try
			{
                Test();
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }

        private static void Test()
        {
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ", vect));
        }

        private static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }
    }
}
