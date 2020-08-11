
using Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                string path = @"D:\workspace\vs2019\CourseNelioAlves\files\names.txt";

                using (StreamReader streamReader = File.OpenText(path))
                {
                    List<Musician> musicians = new List<Musician>();
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        musicians.Add(new Musician(line));
                    }

                    musicians.Sort();
                    foreach (Musician musician in musicians)
                    {
                        Console.WriteLine(musician);
                    }
                }
            }
			catch (IOException ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
