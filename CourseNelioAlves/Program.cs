using CourseNelioAlves.Entities;
using CourseNelioAlves.Entities.Exceptions;
using System;
using System.IO;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\workspace\vs2019\CourseNelioAlves\files\file1.txt";
            string targetPath = @"D:\workspace\vs2019\CourseNelioAlves\files\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                Console.WriteLine("File content:");
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                Console.ReadLine();
            }
            catch (IOException ex)
            {
                Console.WriteLine("An Error Occurred: ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
