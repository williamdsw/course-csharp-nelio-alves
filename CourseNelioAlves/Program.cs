
using Entities;
using Services;
using System;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Enter contract data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Contract value: ");
                double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter the number of installments: ");
                int installments = int.Parse(Console.ReadLine());

                Contract contract = new Contract(number, date, totalValue);
                ContractService contractService = new ContractService(new PaypalService());
                contractService.ProcessContract(contract, installments);

                Console.WriteLine(contract);
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
