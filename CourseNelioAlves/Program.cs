using System;
using System.IO;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfoAndFileExample();
            //FileStreamAndStreamReaderExample();
            //StreamReaderWithFileExample();
            //UsingKeywordExample();
            StreamWriterExample();
        }

        private static void FileInfoAndFileExample()
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

        private static void FileStreamAndStreamReaderExample()
        {
            string path = @"D:\workspace\vs2019\CourseNelioAlves\files\file1.txt";
            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                fileStream = new FileStream(path, FileMode.Open);
                streamReader = new StreamReader(fileStream);
                string line = streamReader.ReadLine();
                Console.WriteLine("First line: ");
                Console.WriteLine(line);
            }
            catch (IOException ex)
            {
                Console.WriteLine("An Error Occurred: ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }

                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        private static void StreamReaderWithFileExample()
        {
            string path = @"D:\workspace\vs2019\CourseNelioAlves\files\file1.txt";
            StreamReader streamReader = null;

            try
            {
                streamReader = File.OpenText(path);
                Console.WriteLine("All content: ");

                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An Error Occurred: ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        private static void UsingKeywordExample()
        {
            string path = @"D:\workspace\vs2019\CourseNelioAlves\files\file1.txt";

            try
            {
                // using (FileStream ...) {}
                using (StreamReader streamReader = File.OpenText(path))
                {
                    Console.WriteLine("File content:");
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occurred: ");
                Console.WriteLine(ex.Message);
            }
        }

        private static void StreamWriterExample()
        {
            string sourcePath = @"D:\workspace\vs2019\CourseNelioAlves\files\file1.txt";
            string targetPath = @"D:\workspace\vs2019\CourseNelioAlves\files\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using(StreamWriter streamWriter = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        streamWriter.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occurred: ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
