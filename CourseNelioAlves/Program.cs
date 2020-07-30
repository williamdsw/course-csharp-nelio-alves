using CourseNelioAlves.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n) ? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("\nPAYMENTS");
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
