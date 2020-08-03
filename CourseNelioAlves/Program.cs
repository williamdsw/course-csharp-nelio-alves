using System;
using System.IO;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader streamReader = new StreamReader(fileStream);
                string line = streamReader.ReadLine();
                streamReader.Close();
                Console.WriteLine(line);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }
    }
}
