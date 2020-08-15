
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
                HashSet<string> set = new HashSet<string>();

                set.Add("TV");
                set.Add("Notebook");
                set.Add("Tablet");

                foreach (string item in set)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine($"Contains Notebook? {set.Contains("Notebook")}");
                Console.WriteLine($"Contains Computer? {set.Contains("Computer")}");
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
