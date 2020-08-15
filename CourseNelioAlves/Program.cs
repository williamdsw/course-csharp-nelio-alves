
using System;
using System.Collections.Generic;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                DateTime dateTime = new DateTime(2019, 08, 15, 13, 15, 12);
                Console.WriteLine(dateTime.ElapsedTime());

                string s1 = "Good morning dear students!";
                Console.WriteLine(s1);
                Console.WriteLine(s1.Cut(10));
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
