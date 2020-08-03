using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Number cannot be a letter or word...");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
        }
    }
}
