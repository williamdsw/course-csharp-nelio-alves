using CourseNelioAlves.Entities;
using CourseNelioAlves.Enums;
using System;
using System.Globalization;
using System.Transactions;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament departament = new Departament(departmentName);
            Worker worker = new Worker(name, level, baseSalary, departament);

            Console.Write("How many contracts to this worker? ");
            int numberOfContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfContracts; i++)
            {
                Console.WriteLine($"Enter {i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime dateTime = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(dateTime, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string[] incomeDate = Console.ReadLine().Split("/");
            int month = int.Parse(incomeDate[0]);
            int year = int.Parse(incomeDate[1]);
            double income = worker.Income(year, month);

            Console.WriteLine("");
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Departament.Name}");
            Console.WriteLine($"Income for: {income.ToString ("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
