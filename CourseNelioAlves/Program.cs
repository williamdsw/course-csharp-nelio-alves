
using Entities;
using Structs;
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
                HashSet<LogEntry> logEntries = new HashSet<LogEntry>();

                Console.Write("Enter file full path: ");
                string path = Console.ReadLine();

                //string path = @"D:\workspace\vs2019\CourseNelioAlves\files\log-access.txt";
                Console.WriteLine();
                using (StreamReader reader = File.OpenText(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);

                        string[] values = line.Split(' ');
                        LogEntry entry = new LogEntry(values[0], DateTime.Parse(values[1]));
                        logEntries.Add(entry);
                    }
                }

                Console.WriteLine($"\nTotal users: {logEntries.Count}");
            }
			catch (IOException ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
