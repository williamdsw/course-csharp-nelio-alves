using CourseNelioAlves.Enums;
using System.Collections.Generic;

namespace CourseNelioAlves.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } // Composition
        public List<HourContract> Contracts { get; } = new List<HourContract>(); // Composition

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament) : 
                this (name, level, baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            Contracts.ForEach(contract =>
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            });

            return sum;
        }
    }
}
