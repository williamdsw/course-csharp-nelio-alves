using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input employee data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Genre: ");
            char genre = char.Parse(Console.ReadLine());
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Employee employee = new Employee();
            employee.Name = name;
            employee.Genre = genre;
            employee.Age = age;

            Console.WriteLine("Employee: {0}", employee);
        }
    }
}
