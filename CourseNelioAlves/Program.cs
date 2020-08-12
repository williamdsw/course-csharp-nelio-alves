
using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                List<Product> listProducts = new List<Product>();

                Console.Write("Enter N: ");
                
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Name and Price: ");
                    string[] values = Console.ReadLine().Split(",");
                    string name = values[0];
                    double price = double.Parse(values[1], CultureInfo.InvariantCulture);

                    Product product = new Product(name, price);
                    listProducts.Add(product);
                }

                CalculationService calculationService = new CalculationService();
                Product max = calculationService.Max(listProducts);

                Console.WriteLine($"Max of Products: {max}");
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
