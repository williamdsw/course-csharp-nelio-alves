using System;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your age: ");
            int age = int.Parse(Console.ReadLine());
            bool canDrive = (age >= 18);
            Console.WriteLine($"Can you get a license driver? {canDrive}");
        }
    }
}
